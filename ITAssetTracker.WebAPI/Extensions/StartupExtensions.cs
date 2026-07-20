using ITAssetTracker.Application;
using ITAssetTracker.Infrastructure;
using ITAssetTracker.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ITAssetTracker.WebAPI.Extensions;

public static class StartupExtensions
{
    // NOTE: This contains service registrations
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddApplicationServices();
        builder.Services.AddInfrastructureServices(builder.Configuration);
        builder.Services.AddPersistenceServices(builder.Configuration);
        builder.Services.AddControllers();
        
        // NOTE: This is to be used by client side technologies?
        // This opens up the API so it can be used by client side technologies
        // The addresses need to be added to the appsettins.json file
        builder.Services.AddCors(
            options => options.AddPolicy(
                "open",
                policy => policy.WithOrigins([builder.Configuration["ApiUrl"] ??
                "https://localhost:7020",
                builder.Configuration["BlazorUrl"] ??
                "https://localhost:7080"])
                .AllowAnyMethod()
                .SetIsOriginAllowed(pol => true)
                .AllowAnyHeader()
                .AllowCredentials()));

        builder.Services.AddSwaggerGen();

        return builder.Build();
    }

    // NOTE: This one is used to add middleware
    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.UseCors("open");

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.MapControllers();

        return app;
    }

    //NOTE: Might want to remove this to test persistence
    /// <summary>
    /// This method is going to get the db context and delete the databse and apply the migrations again.
    /// Every time we run the application we're resetting the database
    /// Good for testing and development purposes as it doesn't clog the databse with test data
    /// </summary>
    /// <param name="app"></param>
    /// <returns></returns>
    public static async Task ResetDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        try
        {
            var context = scope.ServiceProvider.GetService<ITAssetTrackerContext>();
            if(context is not null)
            {
                await context.Database.EnsureDeletedAsync();
                await context.Database.MigrateAsync();
            }
        }
        catch (Exception ex)
        {
            // Add logging here later on
            throw;
        }
    }
}