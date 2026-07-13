using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Persistence.Repositories;
using ITAssetTracker.Persistence.Repositories.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ITAssetTracker.Persistence;

/// <summary>
/// This class extends the IServiceCollection
/// </summary>
public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuation)
    {
        //NOTE: DBContext setup goes here apparently?

        services.AddDbContext<ITAssetTrackerContext>(options => options.UseSqlite(configuation.GetConnectionString("ITAssetTrackerConnectionString")));
        //NOTE: So rather than writing exentions we can just scope the servcies here, and then the UI and API will implement this class
        services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IAssetRepository, EFAssetRepository>();
        services.AddScoped<IAssetAssignmentRepository, EFAssetAssignmentRepository>();
        services.AddScoped<IAssetProductRepository, EFAssetProductRepository>();
        services.AddScoped<IAssetStatusRepository, EFAssetStatusRepository>();
        services.AddScoped<IAssetTypeRepository, EFAssetTypeRepository>();
        services.AddScoped<ICategoryRepository, EFCategoryRepository>();
        services.AddScoped<IDepartmentRepository, EFDepartmentRepository>();
        services.AddScoped<IEmployeeRepository, EFEmployeeRepository>();
        services.AddScoped<IManufacturerRepository, EFManufacturerRepository>();
        services.AddScoped<IPriorityRepository, EFPriorityRepository>();
        services.AddScoped<IResolutionRepository, EFResolutionRepository>();
        services.AddScoped<IRoleRepository, EFRoleRepository>();
        services.AddScoped<ISupportTicketRepository, EFSupportTicketRepository>();
        services.AddScoped<ITicketStatusRepository, EFTicketStatusRepository>();
        services.AddScoped<IUserRepository, EFUserRepository>();

        return services;
    }
}
