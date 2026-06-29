using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.TicketStatuses.Commands.DeleteTicketStatus
{
    public class DeleteTicketStatusCommand: IRequest
    {
        public Guid Id { get; set; }
    }
}
