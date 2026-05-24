using ITAssetTracker.Application.ServiceInterfaces;
using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Application.RepositoryInterfaces;

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
