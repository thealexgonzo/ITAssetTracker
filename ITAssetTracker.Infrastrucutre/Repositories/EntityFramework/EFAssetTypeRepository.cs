using ITAssetTracker.Infrastructure.Entities;
using ITAssetTracker.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Infrastructure.Repositories.EntityFramework;

public class EFAssetTypeRepository : IAssetTypeRepository
{
    private ITAssetTrackerContext _dbContext;

    public EFAssetTypeRepository(ITAssetTrackerContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Retrieves all asset types from the data store.
    /// </summary>
    /// <returns>A list of all asset types. The list is empty if no asset types are found.</returns>
    public List<AssetType> GetAll()
    {
        return _dbContext.AssetTypes.ToList();
    }
}
