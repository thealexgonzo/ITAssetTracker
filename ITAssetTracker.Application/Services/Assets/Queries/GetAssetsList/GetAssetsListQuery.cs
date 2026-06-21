using MediatR;

namespace ITAssetTracker.Application.Services.Assets.Queries.GetAssetsList
{
    public class GetAssetsListQuery: IRequest<List<AssetListViewModel>>
    {
    }
}
