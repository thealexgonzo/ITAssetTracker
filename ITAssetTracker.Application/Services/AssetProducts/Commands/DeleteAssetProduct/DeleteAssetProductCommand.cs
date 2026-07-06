using MediatR;

namespace ITAssetTracker.Application.Services.AssetProducts.Commands.DeleteAssetProduct;

public class DeleteAssetProductCommand: IRequest
{
    public int Id { get; set; }
}
