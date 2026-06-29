using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetStatuses.Queries.GetAssetStatusDetails
{
    public class GetAssetStatusDetailsQuery: IRequest<AssetStatusDetailsViewModel>
    {
        public Guid Id { get; set; }
    }
}
