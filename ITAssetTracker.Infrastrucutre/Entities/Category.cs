namespace ITAssetTracker.Infrastructure.Entities;

public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<AssetType> AssetTypes { get; set; } = new();
}
