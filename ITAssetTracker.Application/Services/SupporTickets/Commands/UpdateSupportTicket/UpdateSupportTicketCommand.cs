using ITAssetTracker.Domain.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Commands.UpdateSupportTicket
{
    public class UpdateSupportTicketCommand: IRequest
    {
        public Guid Id { get; set; }
        public Guid AssetId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid TicketStatusId { get; set; }
        public Guid PriorityId { get; set; }
        public Guid ResolutionId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Comments { get; set; }
        public DateRange ActivePeriod { get; set; } = null!;
    }
}
