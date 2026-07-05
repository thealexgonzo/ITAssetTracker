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
public class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServcies(IServiceCollection services, IConfiguration configuation)
    {
        //NOTE: DBContext setup goes here apparently?
        services.AddDbContext<ITAssetTrackerContext>(options => options.UseSqlite(configuation.GetConnectionString("ITAssetTrackerConnectionString")));

        services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IAssetRepository, EFAssetRepository>();
        //TODO: Add all other repositories 

        return services;
    }
}
