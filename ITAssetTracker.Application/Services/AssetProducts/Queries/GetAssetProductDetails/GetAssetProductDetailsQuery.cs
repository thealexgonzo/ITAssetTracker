using MediatR;

namespace ITAssetTracker.Application.Services.AssetProducts.Queries.GetAssetProductDetails;

public class GetAssetProductDetailsQuery: IRequest<AssetProductDetailsViewModel>
{
    public Guid Id { get; set; }
}
