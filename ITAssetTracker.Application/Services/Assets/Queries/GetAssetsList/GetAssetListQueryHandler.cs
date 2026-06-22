using AutoMapper;
using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Assets.Queries.GetAssetsList;

// NOTE: This is the business logic
public class GetAssetListQueryHandler : IRequestHandler<GetAssetsListQuery, List<AssetListViewModel>>
{
    private readonly IAsyncRepository<Asset> assetRepository;
    private readonly IMapper mapper;

    public GetAssetListQueryHandler(IMapper mapper, IAsyncRepository<Asset> assetRepository)
    {
        this.assetRepository = assetRepository;
        this.mapper = mapper;
    }

    public async Task<List<AssetListViewModel>> Handle(GetAssetsListQuery request, CancellationToken cancellationToken)
    {
        List<Asset> allAssets = (await assetRepository.ListAllAsync())
                                    .OrderBy(x => x.PurchaseDate).ToList();
        return mapper.Map<List<AssetListViewModel>>(allAssets);
    }
}
