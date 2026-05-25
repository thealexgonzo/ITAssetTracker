using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.ServiceInterfaces;

public interface IAssetService
{
    Result<List<Asset>> GetAll();
    Result<Asset> GetById(int id);
    Result<Asset> GetByTag(int tag);
    Result Add(Asset asset);
    Result Edit(Asset asset);
    Result Delete(Asset asset);
    Result<int> GenerateTag();
}
