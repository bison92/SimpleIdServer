﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Security.Cryptography;

namespace SimpleIdServer.Vc.Hashing;

public interface IHashing
{
    HashAlgorithmName Name { get; }
    byte[] Hash(byte[] data);
}
