using ITAssetTracker.Application.RepositoryInterfaces;
using ITAssetTracker.Application.ServiceInterfaces;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.Services;

public class AssetHistoryService : IAssetHistoryService
{
    private IAssetHistoryRepository _assetHistoryService;
    public AssetHistoryService(IAssetHistoryRepository assetHistoryService)
    {
        _assetHistoryService = assetHistoryService;
    }
    public Result<List<AssetHistory>> GetAllAssetHistories(int id)
    {
        try
        {
            return ResultFactory.Success<List<AssetHistory>>(_assetHistoryService.GetAllAssetHistory(id));
        }
        catch (Exception ex)
        {
            return ResultFactory.Fail<List<AssetHistory>>(ex.Message);
        }
    }
}
