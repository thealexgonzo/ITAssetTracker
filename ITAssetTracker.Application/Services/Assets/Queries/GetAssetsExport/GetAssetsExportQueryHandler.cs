using AutoMapper;
using ITAssetTracker.Application.Contracts.Infrastructure;
using ITAssetTracker.Application.Contracts.Repositories;
using MediatR;

namespace ITAssetTracker.Application.Services.Assets.Queries.GetAssetsExport;

public class GetAssetsExportQueryHandler : IRequestHandler<GetAssetsExportQuery, AssetExportFileViewModel>
{
    private readonly IMapper mapper;
    private readonly IAssetRepository assetRepository;
    private readonly ICsvExporter csvExporter;

    public GetAssetsExportQueryHandler(IMapper mapper, IAssetRepository assetRepository, ICsvExporter csvExporter)
    {
        this.mapper = mapper;
        this.assetRepository = assetRepository;
        this.csvExporter = csvExporter;
    }
    public async Task<AssetExportFileViewModel> Handle(GetAssetsExportQuery request, CancellationToken cancellationToken)
    {
        List<AssetExportDTO> allAssets = mapper.Map<List<AssetExportDTO>>(await assetRepository.ListAllAsync());

        byte[] fileData = csvExporter.ExportAssetsToCsv(allAssets);

        AssetExportFileViewModel assetExportFileDto = new AssetExportFileViewModel()
        {
            ContentType = "text/csv",
            Data = fileData,
            AssetExportFileName = $"assets_export_{DateTime.UtcNow}.csv"
        };

        return assetExportFileDto;
    }
}