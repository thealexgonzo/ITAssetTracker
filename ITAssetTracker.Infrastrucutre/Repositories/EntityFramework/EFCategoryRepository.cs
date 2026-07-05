using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.RepositoryInterfaces;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Persistence.Repositories.EntityFramework;

public class EFCategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    private ITAssetTrackerContext _dbContext;

    public EFCategoryRepository(ITAssetTrackerContext dbContext): base(dbContext)
    {
    }
}
