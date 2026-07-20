using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsExport;
using ITAssetTracker.Application.Services.Assignments.Queries.GetAssetAssignmentsExport;

namespace ITAssetTracker.Application.Contracts.Infrastructure;

public interface ICsvExporter
{
    byte[] ExportAssetsToCsv(List<AssetExportDTO> assetExportDtso);
    byte[] ExportAssetAssignmentsToCsv(List<AssetAssignmentsExportDTO> assetAssignmentsExportDtso);
}
