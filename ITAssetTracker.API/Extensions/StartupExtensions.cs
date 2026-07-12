using ITAssetTracker.Application;
using ITAssetTracker.Infrastructure;
using ITAssetTracker.Persistence;

namespace ITAssetTracker.API.Extensions;

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

        return builder.Build();
    }

    // NOTE: This one is used to add middleware
    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.UseCors("open");
        app.UseHttpsRedirection();
        app.MapControllers();

        return app;
    }
}
