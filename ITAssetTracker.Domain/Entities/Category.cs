namespace ITAssetTracker.Domain.Entities;

public class Category
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<AssetType> AssetTypes { get; set; } = new();
}
