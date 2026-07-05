using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Persistence.Repositories.EntityFramework
{
    public class EFManufacturerRepository: BaseRepository<Manufacturer>, IManufacturerRepository
    {
        public EFManufacturerRepository(ITAssetTrackerContext dbContext): base(dbContext)
        {
            
        }
    }
}
