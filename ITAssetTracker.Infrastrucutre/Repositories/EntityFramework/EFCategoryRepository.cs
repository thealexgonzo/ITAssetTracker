using ITAssetTracker.Application.RepositoryInterfaces;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Infrastructure.Repositories.EntityFramework;

public class EFCategoryRepository : ICategoryRepository
{
    private ITAssetTrackerContext _dbContext;

    public EFCategoryRepository(ITAssetTrackerContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Category> GetAll()
    {
        return _dbContext.Categories.ToList();
    }
}
