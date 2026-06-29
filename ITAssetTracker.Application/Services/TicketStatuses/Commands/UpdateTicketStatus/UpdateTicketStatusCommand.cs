using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.TicketStatuses.Commands.UpdateTicketStatus
{
    public class UpdateTicketStatusCommand: IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
