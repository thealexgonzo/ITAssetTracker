using ITAssetTracker.Application.Contracts.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Features.Assets.Queries.GetAssetDetails
{
    public class GetAssetDetailsQuery: IRequest<AssetDetailsDTO>
    {
        public Guid Id { get; set; }
    }
}
