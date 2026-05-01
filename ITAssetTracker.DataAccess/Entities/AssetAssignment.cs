namespace ITAssetTracker.DataAccess.Entities;

public class AssetAssignment
{
    public int AssetAssignmentId { get; set; }
    public int AssetId { get; set; }
    public int EmployeeId{ get; set; }
    public DateTime AssignmentDate { get; set; }
    public DateTime ReturnDate { get; set; }

    public Asset Asset { get; set; } = null!;
    public Employee Employee { get; set; } = null!;
    public List<SupportTicket> SupporTickets { get; set; } = new();
}
