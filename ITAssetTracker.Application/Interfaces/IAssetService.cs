using ITAssetTracker.Infrastructure.Entities;

namespace ITAssetTracker.Application.Interfaces
{
    public interface IAssetService
    {
        Result<List<Asset>> GetAll();
        Result<Asset> GetByTag(int tag);
        Result Add(Asset asset);
        Result Edit(Asset asset);
        Result Delete(Asset asset);
        Result<int> GenerateTag();
    }
}
