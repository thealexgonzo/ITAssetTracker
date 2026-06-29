using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.TicketStatuses.Queries.GetTicketStatusList
{
    public class GetTicketStatusListQuery: IRequest<List<TicketStatusListViewModel>>
    {
    }
}
