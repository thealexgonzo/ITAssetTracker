namespace ITAssetTracker.MVC.Models.Asset;

public class AssetList
{
    public int? SearchTag { get; set; }
    public IEnumerable<Domain.Entities.Asset>? Assets { get; set; }
}
