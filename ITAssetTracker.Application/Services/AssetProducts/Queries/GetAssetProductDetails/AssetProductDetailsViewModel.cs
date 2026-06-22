using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.Services.AssetProducts.Queries.GetAssetProductDetails;

public class AssetProductDetailsViewModel
{
    public Guid Id { get; set; }
    public string Name { get; private set; } = string.Empty;
    public Guid ManufacturerId { get; private set; }
    public Manufacturer Manufacturer { get; set; } = null!;
    public Guid AssetTypeId { get; private set; }
    public AssetType AssetType { get; set; } = null!;
}
