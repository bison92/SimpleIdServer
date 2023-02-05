﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SimpleIdServer.IdServer.Domains;
using SimpleIdServer.IdServer.Options;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.IdServer.Helpers
{
    public interface IAuthenticationHelper
    {
        string GetLogin(User user);
        Task<User> GetUserByLogin(IQueryable<User> users, string login, CancellationToken cancellationToken = default);
        IQueryable<User> FilterUsersByLogin(IQueryable<User> users, string login);
    }

    public class AuthenticationHelper : IAuthenticationHelper
    {
        private readonly IdServerHostOptions _options;

        public AuthenticationHelper(IOptions<IdServerHostOptions> options)
        {
            _options = options.Value;
        }

        public Task<User> GetUserByLogin(IQueryable<User> users, string login, CancellationToken cancellationToken = default)
        {
            if (_options.IsEmailUsedDuringAuthentication) return users.SingleOrDefaultAsync(u => u.Email == login, cancellationToken);
            return users.SingleOrDefaultAsync(u => u.Name == login, cancellationToken);
        }

        public IQueryable<User> FilterUsersByLogin(IQueryable<User> users, string login)
        {
            if (_options.IsEmailUsedDuringAuthentication) return users.Where(u => u.Email == login);
            return users.Where(u => u.Name == login);
        }

        public string GetLogin(User user) => _options.IsEmailUsedDuringAuthentication ? user.Email : user.Name;
    }
}
