using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Persistence.Repositories.EntityFramework
{
    public class EFUserRepository: BaseRepository<User>, IUserRepository
    {
        public EFUserRepository(ITAssetTrackerContext dbContext): base(dbContext)
        {
            
        }
    }
}
