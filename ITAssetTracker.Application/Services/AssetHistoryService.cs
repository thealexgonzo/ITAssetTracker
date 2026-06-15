using ITAssetTracker.Application.Contracts.Repositories;
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
    public Result<List<AssetHistory>> GetAllAssetHistories()
    {
        try
        {
            return ResultFactory.Success<List<AssetHistory>>(_assetHistoryService.GetAll());
        }
        catch (Exception ex)
        {
            return ResultFactory.Fail<List<AssetHistory>>(ex.Message);
        }
    }
}
