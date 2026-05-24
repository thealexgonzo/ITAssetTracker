using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.RepositoryInterfaces;

public interface IAssetProductRepository
{
    List<AssetProduct> GetAll();
}
