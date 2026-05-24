using ITAssetTracker.Application.RepositoryInterfaces;
using ITAssetTracker.Application.ServiceInterfaces;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.Services;

public class AssetStatusService : IAssetStatusService
{
    IAssetStatusRepository _assetStatusService;

    public AssetStatusService(IAssetStatusRepository assetStatusService)
    {
        _assetStatusService = assetStatusService;
    }

    public Result<List<AssetStatus>> GetAllAssetStatuses()
    {
        try
        {
            return ResultFactory.Success<List<AssetStatus>>(_assetStatusService.GetAllAssetStatuses());
        }
        catch (Exception ex)
        {
            return ResultFactory.Fail<List<AssetStatus>>(ex.Message);
        }
    }
}
