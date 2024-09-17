﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
namespace SimpleIdServer.IdServer.IntegrationEvents;
public class UserInfoFailureEvent : IIntegrationEvent
{
    public string EventName => nameof(UserInfoFailureEvent);
    public string ClientId { get; set; }
    public string UserName { get; set; }
    public IEnumerable<string> Scopes { get; set; }
    public string ErrorMessage { get; set; }
    public string Realm { get; set; }
}
