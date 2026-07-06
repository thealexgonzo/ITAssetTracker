using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Resolutions.Queries.GetResolutionDetails
{
    public class GetResolutionDetailsQuery: IRequest<ResolutionDetailsViewModel>
    {
        public int Id { get; set; }
    }
}
