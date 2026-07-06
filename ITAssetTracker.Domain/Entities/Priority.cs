using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Exceptions;

namespace ITAssetTracker.Domain.Entities;

public class Priority: AuditableEntity
{
    public string Name { get; private set; } = string.Empty;
    public List<SupportTicket> SupportTickets { get; set; } = new();

    public Priority(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new BusinessRuleExceptions($"{nameof(name)} is required.");
        }

        
        Name = name;
    }
}
