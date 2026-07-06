using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetTypes.Queries.GetAssetTypeDetails
{
    public class GetAssetTypeDetailsQuery: IRequest<AssetTypeDetailsViewModel>
    {
        public int Id { get; set; }
    }
}
