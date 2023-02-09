﻿// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

// ReSharper disable once CheckNamespace

namespace Masa.Contrib.Service.Caller.DaprClient.Tests;

// ReSharper disable once ClassNeverInstantiated.Global
public class CustomDaprCaller : DaprCallerBase
{
    protected override string AppId { get; set; } = "masa";

    public ICaller GetCaller() => Caller;
}
