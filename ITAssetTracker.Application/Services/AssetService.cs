using ITAssetTracker.Application.Interfaces;
using ITAssetTracker.Infrastructure.Entities;
using ITAssetTracker.Infrastructure.Interfaces;

namespace ITAssetTracker.Application.Services
{
    public class AssetService : IAssetService
    {
        private IAssetRepository _assetService;

        public AssetService(IAssetRepository assetService)
        {
            _assetService = assetService;
        }

        public void Add(Asset asset)
        {
            throw new NotImplementedException();
        }

        public void Delete(Asset asset)
        {
            throw new NotImplementedException();
        }

        public void Edit(Asset asset)
        {
            throw new NotImplementedException();
        }

        public Result<List<Asset>> GetAll()
        {
            try
            {
                return ResultFactory.Success<List<Asset>>(_assetService.GetAll());
            }
            catch (Exception ex)
            {
                return ResultFactory.Fail<List<Asset>>(ex.Message);
            }
        }

        public Result<Asset> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
