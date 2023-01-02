﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using SimpleIdServer.Domains;
using SimpleIdServer.OAuth.DTOs;
using SimpleIdServer.OAuth.Exceptions;
using SimpleIdServer.OAuth.Extensions;
using SimpleIdServer.OAuth.Options;
using SimpleIdServer.Store;
using System;
using System.Linq;
using System.Net;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.OAuth.Api.Register
{
    /// <summary>
    /// https://www.rfc-editor.org/rfc/rfc7591
    /// </summary>
    [Authorize(Constants.Policies.Register)]
    public class RegistrationController : Controller
    {
        private readonly IClientRepository _clientRepository;
        private readonly IRegisterClientRequestValidator _validator;
        private readonly OAuthHostOptions _options;

        public RegistrationController(IClientRepository clientRepository, IRegisterClientRequestValidator validator, IOptions<OAuthHostOptions> options)
        {
            _clientRepository = clientRepository;
            _validator = validator;
            _options = options.Value;
        }

        [HttpPost]
        public async Task<IActionResult> Add(RegisterClientRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await Validate(request, cancellationToken);
                var client = Build(request);
                _clientRepository.Add(client);
                await _clientRepository.SaveChanges(cancellationToken);
                return new ContentResult
                {
                    StatusCode = (int)HttpStatusCode.Created,
                    Content = client.Serialize(Request.GetAbsoluteUriWithVirtualPath()).ToJsonString(),
                    ContentType = "application/json"
                };
            }
            catch (OAuthException ex)
            {
                var jObj = new JsonObject
                {
                    [ErrorResponseParameters.Error] = ex.Code,
                    [ErrorResponseParameters.ErrorDescription] = ex.Message
                };
                return new BadRequestObjectResult(jObj);
            }

            async Task Validate(RegisterClientRequest request, CancellationToken cancellationToken)
            {
                _validator.Validate(request);
                var existingClient = await _clientRepository.Query().AsNoTracking().FirstOrDefaultAsync(c => c.ClientId == request.ClientId, cancellationToken);
                if (existingClient != null) throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.CLIENT_IDENTIFIER_ALREADY_EXISTS, request.ClientId));
            }

            Client Build(RegisterClientRequest request)
            {
                var client = new Client
                {
                    ClientId = request.ClientId,
                    RegistrationAccessToken = Guid.NewGuid().ToString(),
                    CreateDateTime = DateTime.UtcNow,
                    UpdateDateTime = DateTime.UtcNow,
                    RefreshTokenExpirationTimeInSeconds = _options.DefaultRefreshTokenExpirationTimeInSeconds,
                    TokenExpirationTimeInSeconds = _options.DefaultTokenExpirationTimeInSeconds,
                    PreferredTokenProfile = _options.DefaultTokenProfile,
                    ClientSecret = Guid.NewGuid().ToString()
                };
                request.Apply(client, _options);
                return client;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get(string id, CancellationToken cancellationToken)
        {
            var res = await GetClient(id, cancellationToken);
            if (res.HasError) return res.ErrorResult;
            return new OkObjectResult(res.Client.Serialize(Request.GetAbsoluteUriWithVirtualPath()));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string id, CancellationToken cancellationToken)
        {
            var res = await GetClient(id, cancellationToken);
            if (res.HasError) return res.ErrorResult;
            var client = res.Client;
            _clientRepository.Delete(client);
            await _clientRepository.SaveChanges(cancellationToken);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(string id, RegisterClientRequest request, CancellationToken cancellationToken)
        {
            var res = await GetClient(id, cancellationToken);
            if (res.HasError) return res.ErrorResult;
            try
            {
                _validator.Validate(request);
                request.Apply(res.Client, _options);
                await _clientRepository.SaveChanges(cancellationToken);
                return new OkObjectResult(res.Client.Serialize(Request.GetAbsoluteUriWithVirtualPath()));
            }
            catch (OAuthException ex)
            {
                var jObj = new JsonObject
                {
                    [ErrorResponseParameters.Error] = ex.Code,
                    [ErrorResponseParameters.ErrorDescription] = ex.Message
                };
                return new BadRequestObjectResult(jObj);
            }
        }

        private async Task<GetClientResult> GetClient(string id, CancellationToken cancellationToken)
        {
            string accessToken;
            if (!TryExtractAccessToken(out accessToken)) return GetClientResult.Error(Unauthorized());
            var client = await _clientRepository.Query().FirstOrDefaultAsync(c => c.ClientId == id, cancellationToken);
            if (client == null) return GetClientResult.Error(NotFound());
            if (client.RegistrationAccessToken != accessToken) return GetClientResult.Error(Unauthorized());
            return GetClientResult.Ok(client);
        }

        private bool TryExtractAccessToken(out string accessToken)
        {
            StringValues vals;
            accessToken = null;
            if (!Request.Headers.TryGetValue("Authorization", out vals) || !vals.Any()) return false;
            var splittedFirstVal = vals.First().Split(' ');
            if(splittedFirstVal.Count() != 2 && splittedFirstVal.First() != "Bearer") return false;
            accessToken = splittedFirstVal.Last();
            return true;
        }

        private class GetClientResult
        {
            private GetClientResult() { }

            public bool HasError { get; private set; }
            public IActionResult ErrorResult { get; private set; }
            public Client Client { get; private set; }

            public static GetClientResult Error(IActionResult error) => new GetClientResult { HasError = true, ErrorResult = error };

            public static GetClientResult Ok(Client client) => new GetClientResult { HasError = false, Client = client };
        }
    }
}