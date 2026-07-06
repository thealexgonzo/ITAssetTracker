using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Exceptions;

namespace ITAssetTracker.Domain.Entities;

public class TicketStatus: AuditableEntity
{
    public string Name { get; private set; } = string.Empty;
    public List<SupportTicket> SupportTickets { get; set; } = new();

    public TicketStatus(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new BusinessRuleExceptions($"{nameof(name)} is required.");
        }

        
        Name = name;
    }
}
