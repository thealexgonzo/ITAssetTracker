using ITAssetTracker.Infrastructure.Entities;

namespace ITAssetTracker.Application.Interfaces
{
    public interface IAssetService
    {
        Result<List<Asset>> GetAll();
        Result<Asset> GetById(int id);
        void Add(Asset asset);
        void Edit(Asset asset);
        void Delete(Asset asset);
    }
}
