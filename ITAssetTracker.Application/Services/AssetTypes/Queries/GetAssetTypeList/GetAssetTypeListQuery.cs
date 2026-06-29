using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetTypes.Queries.GetAssetTypeList
{
    public class GetAssetTypeListQuery: IRequest<List<AssetTypeListViewModel>>
    {
    }
}
