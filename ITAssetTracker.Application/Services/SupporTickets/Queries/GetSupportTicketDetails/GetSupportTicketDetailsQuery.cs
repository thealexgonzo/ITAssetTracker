using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Queries.GetSupportTicketDetails
{
    public class GetSupportTicketDetailsQuery: IRequest<SupportTicketDetailsViewModel>
    {
        public int Id { get; set; }
    }
}
