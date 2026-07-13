namespace ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;

public class AssetDetailsViewModel
{
    public int Id { get;  set; }
    public string Tag { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int AssetProductId { get; set; }
    //public AssetProduct AssetProducts { get; set; } = null!;
    public int AssetStatusId { get; set; }
    //public AssetStatus AssetStatuses { get; set; } = null!;
    public decimal Price { get; set; }
    public string Location { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string SerialNumber { get; set; } = null!;
    public DateOnly PurchaseDate { get; set; }
    public DateOnly WarrantyExpiryDate { get; set; }
}
