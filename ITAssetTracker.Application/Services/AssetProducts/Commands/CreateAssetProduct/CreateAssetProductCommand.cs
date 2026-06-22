using MediatR;

namespace ITAssetTracker.Application.Services.AssetProducts.Commands.CreateAssetProduct;

public class CreateAssetProductCommand: IRequest<Guid>
{
    public string? Name { get; set; }
    public Guid? ManufacturerId { get; set; }
    public Guid? AssetTypeId { get; private set; }
}
