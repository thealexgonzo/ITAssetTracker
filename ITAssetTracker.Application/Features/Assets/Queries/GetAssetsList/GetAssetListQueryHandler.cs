using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Features.Assets.Queries.GetAssetsList
{
    public class GetAssetListQueryHandler : IRequestHandler<GetAssetsListQuery, List<AssetListDTO>>
    {
        private readonly IAsyncRepository<Asset> assetRepository;
        private readonly IMapper mapper;

        public GetAssetListQueryHandler(IMapper mapper, IAsyncRepository<Asset> assetRepository)
        {
            this.assetRepository = assetRepository;
            this.mapper = mapper;
        }

        public async Task<List<AssetListDTO>> Handle(GetAssetsListQuery request, CancellationToken cancellationToken)
        {
            List<Asset> allAssets = (await assetRepository.GetAll()).OrderBy(x => x.DateRange.start).ToList();
            return mapper.Map<List<AssetListDTO>>(allAssets);
        }
    }
}
