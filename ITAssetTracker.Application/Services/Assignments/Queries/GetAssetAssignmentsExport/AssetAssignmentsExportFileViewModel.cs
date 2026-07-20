namespace ITAssetTracker.Application.Services.Assignments.Queries.GetAssetAssignmentsExport;

public class AssetAssignmentsExportFileViewModel
{
    public string AssetAssignmentsExportFileName { get; set; } = string.Empty;
    public string ContentType { get; set; } = string.Empty;
    public byte[]? Data { get; set; }
}
