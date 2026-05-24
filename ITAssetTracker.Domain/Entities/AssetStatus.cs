namespace ITAssetTracker.Domain.Entities;

public class AssetStatus
{
    public int AssetStatusId { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Asset> Assets { get; set; } = new();
}
