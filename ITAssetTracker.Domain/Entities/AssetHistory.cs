namespace ITAssetTracker.Domain.Entities;

public class AssetHistory
{
    public int AssetHistoryId { get; set; }
    public Guid AssetId { get; set; }
    public Asset Asset { get; set; } = null!;
    public int CreatedByUserId { get; set; }
    public User CreatedByUser { get; set; } = null!;
    public int UpdatedByUserId { get; set; }
    public User UpdatedByUser { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string Comments { get; set; } = string.Empty;
}
