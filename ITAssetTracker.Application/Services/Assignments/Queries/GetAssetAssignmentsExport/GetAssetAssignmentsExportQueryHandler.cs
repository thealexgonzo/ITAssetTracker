using AutoMapper;
using ITAssetTracker.Application.Contracts.Infrastructure;
using ITAssetTracker.Application.Contracts.Repositories;
using MediatR;

namespace ITAssetTracker.Application.Services.Assignments.Queries.GetAssetAssignmentsExport;

public class GetAssetAssignmentsExportQueryHandler : IRequestHandler<GetAssetAssignmentsExportQuery, AssetAssignmentsExportFileViewModel>
{
    private readonly IMapper mapper;
    private readonly IAssetAssignmentRepository assetAssignmentRepository;
    private readonly ICsvExporter csvExporter;

    public GetAssetAssignmentsExportQueryHandler(IMapper mapper, IAssetAssignmentRepository assetAssignmentRepository, ICsvExporter csvExporter)
    {
        this.mapper = mapper;
        this.assetAssignmentRepository = assetAssignmentRepository;
        this.csvExporter = csvExporter;
    }

    public async Task<AssetAssignmentsExportFileViewModel> Handle(GetAssetAssignmentsExportQuery request, CancellationToken cancellationToken)
    {
        List<AssetAssignmentsExportDTO> allAssetAssignments = mapper.Map<List<AssetAssignmentsExportDTO>>(await assetAssignmentRepository.ListAllAsync());

        byte[] fileData = csvExporter.ExportAssetAssignmentsToCsv(allAssetAssignments);

        AssetAssignmentsExportFileViewModel assetAssignmentsExportFileDto = new AssetAssignmentsExportFileViewModel()
        {
            ContentType = "text/csv",
            Data = fileData,
            AssetAssignmentsExportFileName = $"assets_assignments_export_{DateTime.UtcNow}.csv"
        };

        return assetAssignmentsExportFileDto;
    }
}
