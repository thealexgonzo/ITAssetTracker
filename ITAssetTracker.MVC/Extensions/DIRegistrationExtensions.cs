using ITAssetTracker.Application.Interfaces;
using ITAssetTracker.Application.Services;
using ITAssetTracker.Infrastructure.Interfaces;
using ITAssetTracker.Infrastructure.Repositories.EntityFramework;

namespace ITAssetTracker.MVC.Extensions;

/// <summary>
/// Provides extension methods for registering repositories and services with the dependency
/// injection container in a WebApplicationBuilder.
/// </summary>
/// <remarks>These extension methods simplify the setup of required services
/// in ASP.NET Core applications. Call these methods during application startup to ensure that all
/// necessary services are available for dependency injection.</remarks>
public static class DIRegistrationExtensions
{
    public static WebApplicationBuilder AddSupportTicketRepositories(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ISupportTicketService, SupportTicketService>();
        builder.Services.AddScoped<ISupportTicketRepository, EFSupportTicketRepository>();
        return builder;
    }

    public static WebApplicationBuilder AddAssetRepositories(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IAssetService, AssetService>();
        builder.Services.AddScoped<IAssetRepository, EFAssetRepository>();
        return builder;
    }
}
