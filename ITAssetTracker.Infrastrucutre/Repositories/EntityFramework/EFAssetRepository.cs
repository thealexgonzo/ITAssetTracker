using ITAssetTracker.Infrastructure.Entities;
using ITAssetTracker.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Infrastructure.Repositories.EntityFramework
{
    public class EFAssetRepository : IAssetRepository
    {
        private ITAssetTrackerContext _dbContext;

        public EFAssetRepository(ITAssetTrackerContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Asset asset)
        {
            throw new NotImplementedException();
        }

        public void Delete(Asset asset)
        {
            throw new NotImplementedException();
        }

        public void Edit(Asset asset)
        {
            throw new NotImplementedException();
        }

        public List<Asset> GetAll()
        {
            return _dbContext.Assets.ToList();
        }

        public Asset GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
