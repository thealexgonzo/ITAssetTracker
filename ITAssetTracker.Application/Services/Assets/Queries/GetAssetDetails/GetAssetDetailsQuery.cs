using MediatR;

namespace ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;

public class GetAssetDetailsQuery: IRequest<AssetDetailsViewModel>
{
    public Guid Id { get; set; }
}
