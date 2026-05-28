using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.ServiceInterfaces;

public interface IAssetHistoryService
{
    Result<List<AssetHistory>> GetAllAssetHistories(Guid id);
}
