﻿using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Common.Mediator;

public static class MyMediator
{
    public static IServiceCollection AddMyMediator(this IServiceCollection services, Assembly? assembly = null)
    {
        assembly = assembly ?? Assembly.GetCallingAssembly();

        services.AddTransient<IMediator, Mediator>();

        var handlerInterfaceType = typeof(IRequestHandler<,>);

        var handlerTypes = assembly
            .GetTypes()
            .Where(type => !type.IsInterface && !type.IsAbstract)
            .SelectMany(type => type.GetInterfaces()
                .Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == handlerInterfaceType)
                .Select(i => new { Interface = i, Implementation = type }));

        foreach (var handler in handlerTypes)
        {
            services.AddScoped(handler.Interface, handler.Implementation);
        }
        
        return services;
    }
}