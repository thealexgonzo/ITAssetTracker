using ITAssetTracker.Application.ServiceInterfaces;
using ITAssetTracker.Application.Services;
using ITAssetTracker.Application.RepositoryInterfaces;
using ITAssetTracker.Infrastructure.Repositories.EntityFramework;
using System.Net.NetworkInformation;

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

    public static WebApplicationBuilder AddAssetProductRepositories(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IAssetProductService, ModelService>();
        builder.Services.AddScoped<IAssetProductRepository, EFAssetProductRepository>();

        return builder;
    }

    public static WebApplicationBuilder AddAssetTypeRepository(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IAssetTypeService, AssetTypeService>();
        builder.Services.AddScoped<IAssetTypeRepository, EFAssetTypeRepository>();

        return builder;
    }

    public static WebApplicationBuilder AddCategoryRespository(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ICategoryService, CategoryService>();
        builder.Services.AddScoped<ICategoryRepository, EFCategoryRepository>();

        return builder;
    }

    public static WebApplicationBuilder AddAssetStatusRepository(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IAssetStatusService, AssetStatusService>();
        builder.Services.AddScoped<IAssetStatusRepository, EFAssetStatusRepository>();

        return builder;
    }

    public static WebApplicationBuilder AddAssetHistoryRepository(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IAssetHistoryService, AssetHistoryService>();
        builder.Services.AddScoped<IAssetHistoryRepository, EFAssetHistoryRepository>();

        return builder;
    }
}
