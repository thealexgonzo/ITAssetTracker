using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Features.Assets.Queries.GetAssetDetails
{
    public class GetAssetDetailsQueryHandler : IRequestHandler<GetAssetDetailsQuery, AssetDetailsDTO>
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

        public async Task<AssetDetailsDTO> Handle(GetAssetDetailsQuery request, CancellationToken cancellationToken)
        {

            Asset asset = await assetRepository.GetById(request.Id);
            var assetDetailDTO =  mapper.Map<AssetDetailsDTO>(asset);

            var assetProduct = await assetProductRepository.GetById(asset.AssetProductId);
            var assetStatus = await assetStatusRepository.GetById(asset.AssetStatusId);

            assetDetailDTO.AssetProducts = mapper.Map<AssetProduct>(assetProduct);
            assetDetailDTO.AssetStatuses = mapper.Map<AssetStatus>(assetStatus);

            return assetDetailDTO;
        }
    }
}
