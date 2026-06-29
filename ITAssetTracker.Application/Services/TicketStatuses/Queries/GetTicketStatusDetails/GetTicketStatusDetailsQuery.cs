using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.TicketStatuses.Queries.GetTicketStatusDetails
{
    public class GetTicketStatusDetailsQuery: IRequest<TicketStatusDetailsViewModel>
    {
        public Guid Id { get; set; }
    }
}
