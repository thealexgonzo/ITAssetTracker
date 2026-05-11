using ITAssetTracker.Application.Interfaces;
using ITAssetTracker.Infrastructure.Entities;
using ITAssetTracker.Infrastructure.Interfaces;

namespace ITAssetTracker.Application.Services;

public class AssetService : IAssetService
{
    private IAssetRepository _assetService;

    public AssetService(IAssetRepository assetService)
    {
        _assetService = assetService;
    }

    public Result Add(Asset asset)
    {
        try
        {
            _assetService.Add(asset);
            return ResultFactory.Success("Asset added successfully.");
        }
        catch (Exception ex)
        {
            return ResultFactory.Fail(ex.Message);
        }
    }

    public Result Delete(Asset asset)
    {
        try
        {
            _assetService.Delete(asset);
            return ResultFactory.Success("Asset deleted successfully");
        }
        catch (Exception ex)
        {
            return ResultFactory.Fail(ex.Message);
        }
    }

    public Result Edit(Asset asset)
    {
        try
        {
            _assetService.Edit(asset);
            return ResultFactory.Success($"Asset with Id {asset.AssetId} updated successfully");
        }
        catch (Exception ex)
        {
            return ResultFactory.Fail(ex.Message);
        }
    }

    public Result<List<Asset>> GetAll()
    {
        try
        {
            return ResultFactory.Success<List<Asset>>(_assetService.GetAll());
        }
        catch (Exception ex)
        {
            return ResultFactory.Fail<List<Asset>>(ex.Message);
        }
    }

    public Result<Asset> GetByTag(int tag)
    {
        try
        {
            var asset = _assetService.GetByTag(tag);

            return asset is null ?
            ResultFactory.Fail<Asset>($"Asset with tag number: {tag} not found") :
            ResultFactory.Success<Asset>(asset);
            
        }
        catch (Exception ex)
        {
            return ResultFactory.Fail<Asset>(ex.Message);
        }
    }

    public Result<int> GenerateTag()
    {
        try
        {
            return ResultFactory.Success<int>(_assetService.GenerateTag());
        }
        catch (Exception ex)
        {
            return ResultFactory.Fail<int>(ex.Message);
        }
    }
}
