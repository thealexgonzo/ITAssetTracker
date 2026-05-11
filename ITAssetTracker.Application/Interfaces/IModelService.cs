using ITAssetTracker.Infrastructure.Entities;

namespace ITAssetTracker.Application.Interfaces;

public interface IModelService
{
    Result<List<Model>> GetAll();
}
