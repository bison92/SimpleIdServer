﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
namespace SimpleIdServer.IdServer.IntegrationEvents;

public class AddClientScopeFailureEvent : IIntegrationEvent
{
    public string EventName => nameof(AddClientScopeFailureEvent);
    public string Realm { get; set; }
    public string ClientId { get; set; }
    public string Scope { get; set; }
}
