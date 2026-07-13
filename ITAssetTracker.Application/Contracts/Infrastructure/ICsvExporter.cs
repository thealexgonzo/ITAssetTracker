using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsExport;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportAssetsToCsv(List<AssetExportDTO> assetExportDtso);
    }
}
