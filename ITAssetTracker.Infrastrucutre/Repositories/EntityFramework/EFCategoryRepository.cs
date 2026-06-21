using ITAssetTracker.Application.RepositoryInterfaces;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Persistence.Repositories.EntityFramework;

public class EFCategoryRepository : ICategoryRepository
{
    private ITAssetTrackerContext _dbContext;

    public EFCategoryRepository(ITAssetTrackerContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Category> ListAllAsync()
    {
        return _dbContext.Categories.ToList();
    }
}
