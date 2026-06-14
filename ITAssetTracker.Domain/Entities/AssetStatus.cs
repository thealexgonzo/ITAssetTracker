namespace ITAssetTracker.Domain.Entities;

public class AssetStatus
{
    public Guid AssetStatusId { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Asset> Assets { get; set; } = new();
}
