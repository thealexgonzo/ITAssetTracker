namespace ITAssetTracker.WebAPI.Models.Asset;

public class AssetList
{
    public string? SearchTag { get; set; }
    public IEnumerable<Domain.Entities.Asset>? Assets { get; set; }
}
