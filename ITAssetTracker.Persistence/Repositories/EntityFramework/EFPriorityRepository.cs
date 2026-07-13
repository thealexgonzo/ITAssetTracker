using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Persistence.Repositories.EntityFramework
{
    public class EFPriorityRepository: BaseRepository<Priority>, IPriorityRepository
    {
        public EFPriorityRepository(ITAssetTrackerContext dbContext): base(dbContext)
        {
            
        }
    }
}
