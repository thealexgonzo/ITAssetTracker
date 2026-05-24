using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.ServiceInterfaces;

public interface IAssetProductService
{
    Result<List<AssetProduct>> GetAll();
}
