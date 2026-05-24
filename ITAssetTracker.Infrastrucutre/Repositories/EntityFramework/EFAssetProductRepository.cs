using ITAssetTracker.Application.RepositoryInterfaces;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Infrastructure.Repositories.EntityFramework;

public class EFAssetProductRepository : IAssetProductRepository
{
    private ITAssetTrackerContext _dbContext;

    public EFAssetProductRepository(ITAssetTrackerContext dbContext)
    {
        _dbContext = dbContext;
    }
    public List<AssetProduct> GetAll()
    {
        return _dbContext.AssetProducts.ToList();
    }
}
