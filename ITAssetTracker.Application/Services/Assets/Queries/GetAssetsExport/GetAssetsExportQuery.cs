using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Assets.Queries.GetAssetsExport
{
    public class GetAssetsExportQuery: IRequest<AssetExportFileViewModel>
    {
    }
}
