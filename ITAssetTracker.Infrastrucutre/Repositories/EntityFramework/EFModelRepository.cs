using ITAssetTracker.Infrastructure.Entities;
using ITAssetTracker.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ITAssetTracker.Infrastructure.Repositories.EntityFramework;

public class EFModelRepository : IModelRepository
{
    private ITAssetTrackerContext _dbContext;

    public EFModelRepository(ITAssetTrackerContext dbContext)
    {
        _dbContext = dbContext;
    }
    public List<Model> GetAll()
    {
        return _dbContext.Models.ToList();
    }
}
