using MediatR;

namespace ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;

public class GetAssetDetailsQuery: IRequest<AssetDetailsViewModel>
{
    public int Id { get; set; }
}
