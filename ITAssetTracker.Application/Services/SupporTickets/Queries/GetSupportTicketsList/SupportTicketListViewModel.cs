using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Queries.GetSupportTicketsList
{
    public class SupportTicketListViewModel
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
