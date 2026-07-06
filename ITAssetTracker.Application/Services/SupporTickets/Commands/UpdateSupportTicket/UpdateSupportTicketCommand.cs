using ITAssetTracker.Domain.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Commands.UpdateSupportTicket
{
    public class UpdateSupportTicketCommand: IRequest
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public int EmployeeId { get; set; }
        public int TicketStatusId { get; set; }
        public int PriorityId { get; set; }
        public int ResolutionId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Comments { get; set; }
        public DateRange ActivePeriod { get; set; } = null!;
    }
}
