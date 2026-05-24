namespace ITAssetTracker.Domain.Entities;

public class Asset
{
    public int AssetId { get; set; }
    public int Tag { get; set; }
    public string Name { get; set; } = string.Empty;
    public int AssetProductId { get; set; }
    public int AssetStatusId { get; set; }
    public decimal Price { get; set; }
    public string Location { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string SerialNumber { get; set; } = null!;
    public DateTime PurchaseDate { get; set; }
    public DateTime WarrantyExpiryDate { get; set; } 
    public AssetProduct AssetProducts  { get; set; } = null!;
    public AssetStatus AssetStatuses { get; set; } = null!; 
    public List<AssetAssignment> AssetAssignments { get; set; } = new();
    public List<SupportTicket> SupportTickets { get; set; } = new();
}
