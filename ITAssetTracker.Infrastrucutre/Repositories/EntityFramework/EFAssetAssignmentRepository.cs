using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Persistence.Repositories.EntityFramework;

public class EFAssetAssignmentRepository: BaseRepository<AssetAssignment>, IAssetAssignmentRepository
{
    public EFAssetAssignmentRepository(ITAssetTrackerContext dbContext): base(dbContext)
    {
        
    }
}
