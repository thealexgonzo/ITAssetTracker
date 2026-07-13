using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Persistence.Repositories.EntityFramework;

public class EFAssetStatusRepository : BaseRepository<AssetStatus>, IAssetStatusRepository
{
    private ITAssetTrackerContext _dbContext;

    public EFAssetStatusRepository(ITAssetTrackerContext dbContext): base(dbContext)
    {
    }
}
