using ITAssetTracker.Application.ServiceInterfaces;
using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Application.RepositoryInterfaces;

namespace ITAssetTracker.Application.Services;

public class ModelService : IAssetProductService
{
	private IAssetProductRepository _modelService;

    public ModelService(IAssetProductRepository modelService)
    {
		_modelService = modelService;
    }

    public Result<List<AssetProduct>> GetAll()
    {
		try
		{
			return ResultFactory.Success<List<AssetProduct>>(_modelService.GetAll());
		}
		catch (Exception ex)
		{
			return ResultFactory.Fail<List<AssetProduct>>(ex.Message);
		}
    }
}
