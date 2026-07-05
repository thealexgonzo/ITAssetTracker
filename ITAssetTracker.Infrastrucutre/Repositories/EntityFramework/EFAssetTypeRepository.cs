using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Persistence.Repositories.EntityFramework;

public class EFAssetTypeRepository : BaseRepository<AssetType>, IAssetTypeRepository
{
    private ITAssetTrackerContext _dbContext;

    public EFAssetTypeRepository(ITAssetTrackerContext dbContext): base(dbContext)
    {
    }
}
