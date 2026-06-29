using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.TicketStatuses.Queries.GetTicketStatusDetails
{
    public class TicketStatusDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
