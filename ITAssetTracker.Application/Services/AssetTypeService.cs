using ITAssetTracker.Application.Interfaces;
using ITAssetTracker.Infrastructure.Entities;
using ITAssetTracker.Infrastructure.Interfaces;

namespace ITAssetTracker.Application.Services;

public class AssetTypeService : IAssetTypeService
{
    private IAssetTypeRepository _assetTypeService;
    public AssetTypeService(IAssetTypeRepository assetTypeService)
    {
        _assetTypeService = assetTypeService;
    }
    public Result<List<AssetType>> GetAll()
    {
        try
        {
            return ResultFactory.Success<List<AssetType>>(_assetTypeService.GetAll());
        }
        catch (Exception ex)
        {
            return ResultFactory.Fail<List<AssetType>>(ex.Message);
        }
    }
}
