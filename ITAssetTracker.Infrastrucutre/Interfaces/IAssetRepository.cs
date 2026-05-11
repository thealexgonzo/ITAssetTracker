using ITAssetTracker.Infrastructure.Entities;

namespace ITAssetTracker.Infrastructure.Interfaces;

public interface IAssetRepository
{
    List<Asset> GetAll();
    Asset? GetByTag(int tag);
    void Add(Asset asset);
    void Edit(Asset asset);
    void Delete(Asset asset);
    int GenerateTag();
}
