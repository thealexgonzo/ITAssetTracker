using ITAssetTracker.Infrastructure.Entities;

namespace ITAssetTracker.Infrastructure.Interfaces;

public interface IModelRepository
{
    List<Model> GetAll();
}
