namespace ITAssetTracker.Infrastructure.Entities;

public class AssetType
{
    public int AssetTypeId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int CategoryId { get; set; }

    public Category Category { get; set; } = null!;
    public List<Model> Models { get; set; } = new();
}
