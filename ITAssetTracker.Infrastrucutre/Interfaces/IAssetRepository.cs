using ITAssetTracker.Infrastructure.Entities;

namespace ITAssetTracker.Infrastructure.Interfaces;

public interface IAssetRepository
{
    List<Asset> GetAll();
    Asset GetById(int id);
    void Add(Asset asset);
    void Edit(Asset asset);
    void Delete(Asset asset);
}
