using ITAssetTracker.Application.Interfaces;
using ITAssetTracker.Infrastructure.Entities;
using ITAssetTracker.Infrastructure.Interfaces;

namespace ITAssetTracker.Application.Services;

public class ModelService : IModelService
{
	private IModelRepository _modelService;

    public ModelService(IModelRepository modelService)
    {
		_modelService = modelService;
    }

    public Result<List<Model>> GetAll()
    {
		try
		{
			return ResultFactory.Success<List<Model>>(_modelService.GetAll());
		}
		catch (Exception ex)
		{
			return ResultFactory.Fail<List<Model>>(ex.Message);
		}
    }
}
