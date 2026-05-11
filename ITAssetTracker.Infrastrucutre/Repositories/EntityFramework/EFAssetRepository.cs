using ITAssetTracker.Infrastructure.Entities;
using ITAssetTracker.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ITAssetTracker.Infrastructure.Repositories.EntityFramework;

public class EFAssetRepository : IAssetRepository
{
    private ITAssetTrackerContext _dbContext;

    public EFAssetRepository(ITAssetTrackerContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(Asset asset)
    {
        _dbContext.Assets.Add(asset);
        _dbContext.SaveChanges();
    }

    public void Delete(Asset asset)
    {
        _dbContext.Assets.Remove(asset);
        _dbContext.SaveChanges();
    }

    public void Edit(Asset asset)
    {
        _dbContext.Assets.Update(asset);
        _dbContext.SaveChanges();
    }

    public List<Asset> GetAll()
    {
        return _dbContext.Assets.Include(m => m.Models).ToList();
    }

    public Asset? GetByTag(int tag)
    {
        return _dbContext.Assets.Include(m => m.Models).FirstOrDefault(a => a.Tag == tag) ?? null;
    }

    public int GenerateTag()
    {
        return _dbContext.Assets.Max(a => a.Tag) + 1;
    }
}
