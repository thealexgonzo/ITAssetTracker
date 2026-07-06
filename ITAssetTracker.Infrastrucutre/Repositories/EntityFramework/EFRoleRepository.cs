using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Persistence.Repositories.EntityFramework;

public class EFRoleRepository: BaseRepository<Role>, IRoleRepository
{
    public EFRoleRepository(ITAssetTrackerContext dbContext) : base(dbContext)
    {

    }
}
