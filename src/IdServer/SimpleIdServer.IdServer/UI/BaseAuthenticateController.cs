﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using MassTransit;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SimpleIdServer.IdServer.Domains;
using SimpleIdServer.IdServer.Events;
using SimpleIdServer.IdServer.Helpers;
using SimpleIdServer.IdServer.Options;
using SimpleIdServer.IdServer.Store;
using SimpleIdServer.IdServer.UI.Services;
using SimpleIdServer.IdServer.UI.ViewModels;
using System;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.IdServer.UI
{
    public class BaseAuthenticateController : Controller
    {
        private readonly IdServerHostOptions _options;
        private readonly IDataProtector _dataProtector;
        private readonly IClientRepository _clientRepository;
        private readonly IAmrHelper _amrHelper;
        private readonly IUserRepository _userRepository;
        private readonly IUserTransformer _userTransformer;
        private readonly IBusControl _busControl;

        public BaseAuthenticateController(
            IOptions<IdServerHostOptions> options,
            IDataProtectionProvider dataProtectionProvider,
            IClientRepository clientRepository,
            IAmrHelper amrHelper,
            IUserRepository userRepository,
            IUserTransformer userTransformer,
            IBusControl busControl)
        {
            _options = options.Value;
            _dataProtector = dataProtectionProvider.CreateProtector("Authorization");
            _clientRepository = clientRepository;
            _amrHelper = amrHelper;
            _userRepository = userRepository;
            _userTransformer = userTransformer;
            _busControl = busControl;
        }

        protected IClientRepository ClientRepository => _clientRepository;
        protected IUserRepository UserRepository => _userRepository;
        protected IdServerHostOptions Options => _options;
        protected IBusControl Bus => _busControl;

        protected JsonObject ExtractQuery(string returnUrl) => ExtractQueryFromUnprotectedUrl(Unprotect(returnUrl));

        protected JsonObject ExtractQueryFromUnprotectedUrl(string returnUrl)
        {
            var query = returnUrl.GetQueries().ToJsonObject();
            if (query.ContainsKey("returnUrl"))
                return ExtractQuery(query["returnUrl"].GetValue<string>());

            return query;
        }

        protected string Unprotect(string returnUrl)
        {
            var unprotectedUrl = _dataProtector.Unprotect(returnUrl);
            return unprotectedUrl;
        }

        protected bool IsProtected(string returnUrl)
        {
            try
            {
                _dataProtector.Unprotect(returnUrl);
                return true;
            }
            catch
            {
                return false;
            }
        }

        protected void SetSuccessMessage(string msg)
        {
            ViewBag.SuccessMessage = msg;
        }

        protected async Task<User> FetchAuthenticatedUser(string realm, AmrAuthInfo amrInfo, CancellationToken cancellationToken)
        {
            if (amrInfo == null || string.IsNullOrWhiteSpace(amrInfo.UserId)) return null;
            return await _userRepository.Query().Include(u => u.Realms).Include(c => c.OAuthUserClaims).FirstOrDefaultAsync(u => u.Realms.Any(r => r.RealmsName == realm) && u.Id == amrInfo.UserId, cancellationToken);
        }

        protected async Task<AmrAuthInfo> ResolveAmrInfo(JsonObject query, string realm, Client client, CancellationToken cancellationToken)
        {
            var amrInfo = GetAmrInfo();
            if (amrInfo != null) return amrInfo;
            var acrValues = query.GetAcrValuesFromAuthorizationRequest();
            var requestedClaims = query.GetClaimsFromAuthorizationRequest();
            var acr = await _amrHelper.FetchDefaultAcr(realm, acrValues, requestedClaims, client, cancellationToken);
            if (acr == null) return null;
            return new AmrAuthInfo(null, acr.AuthenticationMethodReferences, acr.AuthenticationMethodReferences.First());
        }

        protected AmrAuthInfo GetAmrInfo()
        {
            if (!HttpContext.Request.Cookies.ContainsKey(Constants.DefaultCurrentAmrCookieName)) return null;
            var amr = JsonSerializer.Deserialize<AmrAuthInfo>(HttpContext.Request.Cookies[Constants.DefaultCurrentAmrCookieName]);
            return amr;
        }

        protected async Task<IActionResult> Authenticate(string realm, string returnUrl, string currentAmr, User user, CancellationToken token, bool rememberLogin = false)
        {
            if (!IsProtected(returnUrl))
            {
                return await Sign(realm, returnUrl, currentAmr, user, token, rememberLogin);
            }

            var unprotectedUrl = Unprotect(returnUrl);
            var query = ExtractQuery(returnUrl);
            var acrValues = query.GetAcrValuesFromAuthorizationRequest();
            var clientId = query.GetClientIdFromAuthorizationRequest();
            var requestedClaims = query.GetClaimsFromAuthorizationRequest();
            var client = await _clientRepository.Query().Include(c => c.Realms).FirstOrDefaultAsync(c => c.ClientId == clientId && c.Realms.Any(r => r.Name == realm), token);
            var acr = await _amrHelper.FetchDefaultAcr(realm, acrValues, requestedClaims, client, token);
            string amr;
            if (acr == null || string.IsNullOrWhiteSpace(amr = _amrHelper.FetchNextAmr(acr, currentAmr)))
            {
                return await Sign(realm, unprotectedUrl, currentAmr, user, token, rememberLogin);
            }

            var allAmr = acr.AuthenticationMethodReferences;
            HttpContext.Response.Cookies.Append(Constants.DefaultCurrentAmrCookieName, JsonSerializer.Serialize(new AmrAuthInfo(user.Id, allAmr, amr)));
            return RedirectToAction("Index", "Authenticate", new { area = amr, ReturnUrl = returnUrl });
        }

        protected async Task<IActionResult> Sign(string realm, string returnUrl, string currentAmr, User user, CancellationToken token, bool rememberLogin = false)
        {
            await AddSession(realm, user, currentAmr, token);
            var offset = DateTimeOffset.UtcNow.AddSeconds(_options.CookieAuthExpirationTimeInSeconds);
            var claims = _userTransformer.Transform(user);
            var claimsIdentity = new ClaimsIdentity(claims, currentAmr);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            if (rememberLogin)
            {
                await HttpContext.SignInAsync(claimsPrincipal, new AuthenticationProperties
                {
                    IsPersistent = true
                });
            }
            else
            {
                await HttpContext.SignInAsync(claimsPrincipal, new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = offset
                });
            }

            await _busControl.Publish(new UserLoginSuccessEvent
            {
                Realm = realm,
                UserName = user.Name,
                Amr = currentAmr
            }, token);
            return Redirect(returnUrl);
        }

        protected async Task AddSession(string realm, User user, string currentAmr, CancellationToken cancellationToken)
        {
            var currentDateTime = DateTime.UtcNow;
            var expirationDateTime = currentDateTime.AddSeconds(_options.CookieAuthExpirationTimeInSeconds);
            var claims = user.Claims;
            user.AddSession(realm, expirationDateTime);
            await _userRepository.SaveChanges(cancellationToken);
            Response.Cookies.Append(_options.GetSessionCookieName(), user.GetActiveSession(realm).SessionId, new CookieOptions
            {
                Secure = true,
                HttpOnly = false,
                SameSite = SameSiteMode.None
            });
        }
    }
}
