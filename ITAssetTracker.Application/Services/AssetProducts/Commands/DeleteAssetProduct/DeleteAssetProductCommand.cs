using MediatR;

namespace ITAssetTracker.Application.Services.AssetProducts.Commands.DeleteAssetProduct;

public class DeleteAssetProductCommand: IRequest
{
    public Guid Id { get; set; }
}
