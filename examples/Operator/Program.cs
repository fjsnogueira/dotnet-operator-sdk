﻿using KubeOps.Operator;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = Host.CreateApplicationBuilder(args);

builder.Logging.SetMinimumLevel(LogLevel.Trace);

builder.Services
    .AddKubernetesOperator()
    .RegisterComponents();

using var host = builder.Build();
await host.RunAsync();
