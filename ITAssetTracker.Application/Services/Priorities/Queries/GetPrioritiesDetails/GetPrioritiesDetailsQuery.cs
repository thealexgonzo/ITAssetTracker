using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Priorities.Queries.GetPrioritiesDetails
{
    public class GetPrioritiesDetailsQuery: IRequest<PrioritiesDetailsViewModel>
    {
        public Guid Id { get; set; }
    }
}
