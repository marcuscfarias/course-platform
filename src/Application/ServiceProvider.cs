﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ServiceProvider
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        
        return services;
    }
}