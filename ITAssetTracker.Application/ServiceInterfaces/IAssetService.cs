using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.ServiceInterfaces;

public interface IAssetService
{
    Result<List<Asset>> GetAll();
    Result<Asset> GetById(Guid id);
    Result<Asset> GetByTag(string tag);
    Result Add(Asset asset);
    Result Edit(Asset asset);
    Result Delete(Asset asset);
}
