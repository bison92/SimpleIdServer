﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.AspNetCore.Authentication.WsFederation;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleIdServer.IdServer
{
    public static class AuthBuilderExtensions
    {
        public static AuthBuilder AddWsAuthentication(this AuthBuilder authBuilder, Action<WsFederationOptions> configureOptions = null)
        {
            authBuilder.Builder.AddWsFederation(Constants.DefaultOIDCAuthenticationScheme, configureOptions == null ? (o) =>
            {
                o.SignInScheme = Constants.DefaultCertificateAuthenticationScheme;
                o.MetadataAddress = "http://localhost:60001/FederationMetadata/2007-06/FederationMetadata.xml";
                o.Wtrealm = "urn:website";
                o.RequireHttpsMetadata = false;
            }
            : configureOptions);
            return authBuilder;
        }
    }
}
