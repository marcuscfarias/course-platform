using System.Runtime.CompilerServices;
using Domain.Repositories;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ServiceProvider
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddDatabaseContext(configuration);

        return services;
    }

    private static void AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = GetConnectionString(configuration);
        services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            }
        );

        services.AddScoped<ApplicationDbContext>();
    }

    private static string GetConnectionString(IConfiguration configuration)
    {
        //TODO: improve migrations, think about (logs, etc...)
        
        // //appSettings
        // string? connectionString = configuration.GetConnectionString("DefaultConnection");
        
        //docker
        string? connectionString = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");

        if (connectionString is null)
        {
            throw new Exception("Invalid connection string.");
        }

        return connectionString;
    }
}