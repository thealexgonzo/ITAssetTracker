using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Commands.DeleteSupportTicket
{
    public class DeleteSupportTicketCommand: IRequest
    {
        public Guid Id { get; set; }
    }
}
