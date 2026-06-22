using MediatR;

namespace ITAssetTracker.Application.Services.AssetProducts.Commands.UpdateAssetProduct;

public class UpdateAssetProductCommand: IRequest
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public Guid? ManufacturerId { get; set; }
    public Guid? AssetTypeId { get; private set; }
}
