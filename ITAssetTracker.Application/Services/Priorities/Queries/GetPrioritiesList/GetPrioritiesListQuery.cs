using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Priorities.Queries.GetPrioritiesList
{
    public class GetPrioritiesListQuery: IRequest<List<PrioritiesListViewModel>>
    {
    }
}
