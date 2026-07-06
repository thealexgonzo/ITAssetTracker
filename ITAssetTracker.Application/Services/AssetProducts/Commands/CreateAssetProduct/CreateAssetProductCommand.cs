using MediatR;

namespace ITAssetTracker.Application.Services.AssetProducts.Commands.CreateAssetProduct;

public class CreateAssetProductCommand: IRequest<int>
{
    public string? Name { get; set; }
    public int? ManufacturerId { get; set; }
    public int? AssetTypeId { get; private set; }
}
