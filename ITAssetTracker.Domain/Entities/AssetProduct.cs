namespace ITAssetTracker.Domain.Entities;

public class AssetProduct
{
    public int AssetProductId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int ManufacturerId { get; set; }
    public int AssetTypeId { get; set; }
    public Manufacturer Manufacturer { get; set; } = null!;
    public AssetType AssetType { get; set; } = null!;
    public List<Asset> Assets { get; set; } = new();
}
