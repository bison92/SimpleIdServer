﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using System.Text.Json.Serialization;

namespace SimpleIdServer.IdServer.VerifiablePresentation.Apis;

public class PresentationSubmissionDescriptorMap
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("format")]
    public string Format { get; set; }
    [JsonPropertyName("path")]
    public string Path { get; set; }
}
