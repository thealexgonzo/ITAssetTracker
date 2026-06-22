using MediatR;

namespace ITAssetTracker.Application.Services.AssetProducts.Queries.GetAssetProductList;

public class GetAssetProductListQuery: IRequest<List<AssetProductListViewModel>>
{
}
