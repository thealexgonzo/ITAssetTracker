using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.Contracts.Repositories
{
    public interface IAssetRepository : IAsyncRepository<Asset>
    {
        // NOTE: Specific requests and commands would go in here
        Task<Asset?> GetByTag(string tag);
    }
}
