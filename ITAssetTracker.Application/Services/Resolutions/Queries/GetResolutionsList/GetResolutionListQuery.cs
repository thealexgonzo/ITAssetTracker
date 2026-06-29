using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Resolutions.Queries.GetResolutionsList
{
    public class GetResolutionListQuery: IRequest<List<ResolutionListViewModel>>
    {
    }
}
