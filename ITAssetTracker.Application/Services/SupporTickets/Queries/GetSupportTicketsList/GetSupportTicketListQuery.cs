using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Queries.GetSupportTicketsList
{
    public class GetSupportTicketListQuery: IRequest<List<SupportTicketListViewModel>>
    {
    }
}
