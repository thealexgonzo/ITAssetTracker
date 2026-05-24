using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.ServiceInterfaces;

public interface IAssetStatusService
{
    Result<List<AssetStatus>> GetAllAssetStatuses();
}
