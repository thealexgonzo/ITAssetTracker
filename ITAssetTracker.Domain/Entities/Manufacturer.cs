namespace ITAssetTracker.Domain.Entities;

public class Manufacturer
{
    public int ManufacturerId { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<AssetProduct> AssetProducts { get; set; } = new();
}
