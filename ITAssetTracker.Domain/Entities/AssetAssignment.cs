namespace ITAssetTracker.Domain.Entities;

public class AssetAssignment
{
    public int AssetAssignmentId { get; set; }
    public int AssetId { get; set; }
    public Asset Asset { get; set; } = null!;
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;
    public DateTime AssignedDate { get; set; }
    public DateTime? ReturnedDate { get; set; }
}
