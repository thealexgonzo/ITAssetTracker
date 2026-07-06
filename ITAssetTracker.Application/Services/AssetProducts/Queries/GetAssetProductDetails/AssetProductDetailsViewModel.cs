using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.Services.AssetProducts.Queries.GetAssetProductDetails;

public class AssetProductDetailsViewModel
{
    public int Id { get; set; }
    public string Name { get; private set; } = string.Empty;
    public int ManufacturerId { get; private set; }
    public Manufacturer Manufacturer { get; set; } = null!;
    public int AssetTypeId { get; private set; }
    public AssetType AssetType { get; set; } = null!;
}
