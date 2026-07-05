using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Persistence.Repositories.EntityFramework;

public class EFAssetProductRepository : BaseRepository<AssetProduct>, IAssetProductRepository
{
    public EFAssetProductRepository(ITAssetTrackerContext dbContext): base(dbContext)
    {

    }
}
