using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.RepositoryInterfaces;

public interface IAssetHistoryRepository
{
    List<AssetHistory> GetAllAssetHistory(int id);
}
