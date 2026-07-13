using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ITAssetTracker.Persistence.Repositories.EntityFramework;

public class EFAssetRepository : BaseRepository<Asset>, IAssetRepository
{

    public EFAssetRepository(ITAssetTrackerContext dbContext) : base(dbContext)
    {
    }

    public Task<Asset?> GetByTag(string tag)
    {
        return dbContext.Assets.Include(ap => ap.AssetProducts).FirstOrDefaultAsync(at => at.Tag == tag);
    }
}
