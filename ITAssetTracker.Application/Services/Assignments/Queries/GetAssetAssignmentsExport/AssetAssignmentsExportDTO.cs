namespace ITAssetTracker.Application.Services.Assignments.Queries.GetAssetAssignmentsExport;

public class AssetAssignmentsExportDTO
{
    public int Id { get; set; }
    public int AssetId { get; set; }
    public int EmployeeId { get; set; }
    public DateOnly AssignedDate { get; set; }
    public DateOnly ReturnedDate { get; set; }
}
