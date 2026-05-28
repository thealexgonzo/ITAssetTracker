using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.RepositoryInterfaces;

public interface IAssetRepository
{
    List<Asset> GetAll();
    Asset? GetByTag(string tag);
    Asset? GetById(Guid id);
    void Add(Asset asset);
    void Edit(Asset asset);
    void Delete(Asset asset);
    int GenerateTag();
}