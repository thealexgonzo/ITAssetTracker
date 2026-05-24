using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.RepositoryInterfaces;

public interface IAssetStatusRepository
{
    List<AssetStatus> GetAllAssetStatuses();
}
