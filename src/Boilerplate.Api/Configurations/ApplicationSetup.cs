using Boilerplate.Application.Common;
using Boilerplate.Infrastructure;
using MassTransit;
using MassTransit.NewIdProviders;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Boilerplate.Api.Configurations;

public static class ApplicationSetup
{
    public static IServiceCollection AddApplicationSetup(this IServiceCollection services)
    {
        string message = "This is a IServiceCollection!!!.";
        Console.WriteLine(message);
        services.AddScoped<IContext, ApplicationDbContext>();
        NewId.SetProcessIdProvider(new CurrentProcessIdProvider());
        
        return services;
    }
    
    
}