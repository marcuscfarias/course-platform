using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace API.Configurations;

public static class ConfigureApps
{
    public static void AddApps(this WebApplication app)
    {
        app.RunDatabaseMigrations();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            //TODO: config docker secrets
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();
    }

    private static void RunDatabaseMigrations(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var db = (ApplicationDbContext)scope.ServiceProvider.GetRequiredService(typeof(ApplicationDbContext));
        db.Database.Migrate();
    }
}