using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Queries.GetSupportTicketDetails
{
    public class EmployeeDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = string.Empty;
    }
}
