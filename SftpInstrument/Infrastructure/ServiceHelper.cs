using System;
using Microsoft.Extensions.DependencyInjection;

namespace SftpInstrument.Infrastructure;

internal static class ServiceHelper
{
    public static IServiceProvider Services { get; private set; }
    public static void Initialize(IServiceProvider services) => Services = services;

    public static T GetService<T>() => Services.GetService<T>();
}