using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Features.Assets.Queries.GetAssetsList
{
    public class GetAssetsListQuery: IRequest<List<AssetListDTO>>
    {
    }
}
