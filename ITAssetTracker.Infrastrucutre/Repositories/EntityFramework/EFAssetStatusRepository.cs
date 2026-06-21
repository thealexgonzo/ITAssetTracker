using ITAssetTracker.Application.RepositoryInterfaces;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Persistence.Repositories.EntityFramework;

public class EFAssetStatusRepository : IAssetStatusRepository
{
    private ITAssetTrackerContext _dbContext;

    public EFAssetStatusRepository(ITAssetTrackerContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<AssetStatus> GetAllAssetStatuses()
    {
        return _dbContext.AssetStatuses.ToList();
    }
}
