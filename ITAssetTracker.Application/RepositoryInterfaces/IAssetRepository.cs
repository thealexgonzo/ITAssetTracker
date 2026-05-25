using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.RepositoryInterfaces;

public interface IAssetRepository
{
    List<Asset> GetAll();
    Asset? GetByTag(int tag);
    Asset? GetById(int id);
    void Add(Asset asset);
    void Edit(Asset asset);
    void Delete(Asset asset);
    int GenerateTag();
}