using Application;
using Infrastructure;

namespace API.Configurations;

public static class ConfigureServices
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Add services to the container.
        services.AddControllers();
        services.AddLogging();
        
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        
        services.AddInfrastructure(configuration);
        services.AddApplication(configuration);

        return services;
    }
}