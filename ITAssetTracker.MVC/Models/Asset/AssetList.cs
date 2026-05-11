namespace ITAssetTracker.MVC.Models.Asset;

public class AssetList
{
    public int? SearchTag { get; set; }
    public IEnumerable<Infrastructure.Entities.Asset>? Assets { get; set; }
}
