namespace ITAssetTracker.Domain.Entities;

public class AssetType
{
    public Guid AssetTypeId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
    public List<AssetProduct> AssetProducts { get; set; } = new();
}
