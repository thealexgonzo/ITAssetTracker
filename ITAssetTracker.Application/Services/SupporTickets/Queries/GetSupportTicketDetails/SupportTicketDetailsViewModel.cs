using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Queries.GetSupportTicketDetails
{
    public class SupportTicketDetailsViewModel
    {
        public Guid Id { get; set; }
        public Guid AssetId { get; set; }
        public Asset Asset { get; set; } = null!;
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
        public Guid TicketStatusId { get; set; }
        public TicketStatus TicketStatus { get; set; } = null!;
        public Guid PriorityId { get; set; }
        public Priority Priority { get; set; } = null!;
        public Guid ResolutionId { get; set; }
        public Resolution Resolution { get; set; } = null!;
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Comments { get; set; }
        public DateRange ActivePeriod { get; set; } = null!;
    }
}
