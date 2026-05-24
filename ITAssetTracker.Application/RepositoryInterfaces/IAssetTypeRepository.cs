using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.RepositoryInterfaces;

public interface IAssetTypeRepository
{
    List<AssetType> GetAll();
}
