using ITAssetTracker.Infrastructure.Entities;

namespace ITAssetTracker.Infrastructure.Interfaces;

public interface IAssetTypeRepository
{
    List<AssetType> GetAll();
}
