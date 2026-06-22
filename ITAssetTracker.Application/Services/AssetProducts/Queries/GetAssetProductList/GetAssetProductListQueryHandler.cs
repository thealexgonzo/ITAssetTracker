using AutoMapper;
using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.AssetProducts.Queries.GetAssetProductList;

public class GetAssetProductListQueryHandler : IRequestHandler<GetAssetProductListQuery, List<AssetProductListViewModel>>
{
    private readonly IMapper mapper;
    private readonly IAsyncRepository<AssetProduct> assetProductRepository;

    public GetAssetProductListQueryHandler(IMapper mapper, IAsyncRepository<AssetProduct> assetProductRepository)
    {
        this.mapper = mapper;
        this.assetProductRepository = assetProductRepository;
    }
    public async Task<List<AssetProductListViewModel>> Handle(GetAssetProductListQuery request, CancellationToken cancellationToken)
    {
        List<AssetProduct> allAssetProducts = (await assetProductRepository.ListAllAsync())
                                    .OrderBy(x => x.CreatedDate).ToList();

        return mapper.Map<List<AssetProductListViewModel>>(allAssetProducts);
    }
}
