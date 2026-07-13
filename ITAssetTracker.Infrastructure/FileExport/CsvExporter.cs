using CsvHelper;
using ITAssetTracker.Application.Contracts.Infrastructure;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsExport;
using System.Globalization;

namespace ITAssetTracker.Infrastructure.FileExport;

public class CsvExporter : ICsvExporter
{
    public byte[] ExportAssetsToCsv(List<AssetExportDTO> assetExportDtso)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.CurrentCulture);
            csvWriter.WriteRecords(assetExportDtso);
        }

        return memoryStream.ToArray();
    }
}
