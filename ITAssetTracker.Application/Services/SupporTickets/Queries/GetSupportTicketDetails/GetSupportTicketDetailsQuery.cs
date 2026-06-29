using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Queries.GetSupportTicketDetails
{
    public class GetSupportTicketDetailsQuery: IRequest<SupportTicketDetailsViewModel>
    {
        public Guid Id { get; set; }
    }
}
