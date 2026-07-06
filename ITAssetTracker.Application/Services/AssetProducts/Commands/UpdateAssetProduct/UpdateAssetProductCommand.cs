using MediatR;

namespace ITAssetTracker.Application.Services.AssetProducts.Commands.UpdateAssetProduct;

public class UpdateAssetProductCommand: IRequest
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? ManufacturerId { get; set; }
    public int? AssetTypeId { get; private set; }
}
