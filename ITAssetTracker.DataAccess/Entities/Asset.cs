namespace ITAssetTracker.DataAccess.Entities;

public class Asset
{
    public int AssetId { get; set; }
    public int Tag { get; set; }
    public string Name { get; set; } = string.Empty;
    public int TypeId { get; set; }
    public int ManufacturerId { get; set; }
    public int ModelId { get; set; }
    public string Description { get; set; } = string.Empty;

    public Model Models { get; set; } = null!;
    public List<AssetAssignment> AssetAssignments { get; set; } = new();
}
