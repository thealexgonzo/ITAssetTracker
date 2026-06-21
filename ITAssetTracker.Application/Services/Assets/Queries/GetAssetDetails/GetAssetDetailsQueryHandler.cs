using AutoMapper;
using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails
{
    public class GetAssetDetailsQueryHandler : IRequestHandler<GetAssetDetailsQuery, AssetDetailsViewModel>
    {
        private readonly IAsyncRepository<Asset> assetRepository;
        private readonly IAsyncRepository<AssetProduct> assetProductRepository;
        private readonly IAsyncRepository<AssetStatus> assetStatusRepository;
        private readonly IMapper mapper;

        public GetAssetDetailsQueryHandler(IAsyncRepository<Asset> assetRepository, IAsyncRepository<AssetProduct> assetProductRepository, IAsyncRepository<AssetStatus> assetStatusRepository, IMapper mapper)
        {
            this.assetRepository = assetRepository;
            this.assetProductRepository = assetProductRepository;
            this.assetStatusRepository = assetStatusRepository;
            this.mapper = mapper;
        }

        public async Task<AssetDetailsViewModel> Handle(GetAssetDetailsQuery request, CancellationToken cancellationToken)
        {

            Asset asset = await assetRepository.GetByIdAsync(request.Id)!;
            AssetDetailsViewModel assetDetailViewModel =  mapper.Map<AssetDetailsViewModel>(asset);

            AssetProduct assetProduct = await assetProductRepository.GetByIdAsync(asset.AssetProductId)!;
            AssetStatus assetStatus = await assetStatusRepository.GetByIdAsync(asset.AssetStatusId)!;

            assetDetailViewModel.AssetProducts = mapper.Map<AssetProduct>(assetProduct);
            assetDetailViewModel.AssetStatuses = mapper.Map<AssetStatus>(assetStatus);

            return assetDetailViewModel;
        }
    }
}
