using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Exceptions;
using ITAssetTracker.Domain.ValueObjects;

namespace ITAssetTracker.Domain.Entities;

public class SupportTicket: AuditableEntity
{
    public int AssetId { get; private set; }
    public Asset Asset { get; set; } = null!;
    public int EmployeeId { get; private set; }
    public Employee Employee { get; set; } = null!;
    public int TicketStatusId { get; private set; }
    public TicketStatus TicketStatus { get; set; } = null!;
    public int PriorityId { get; private set; }
    public Priority Priority { get; set; } = null!;
    public int ResolutionId { get; private set; }
    public Resolution Resolution { get; set; } = null!;
    public string Title { get; private set; } = string.Empty;
    public string? Description { get; private set; }
    public string? Comments { get; private set; }
    public DateRange ActivePeriod { get; private set; }

    public SupportTicket(int assetId, int employeeId, int ticketStatusId, int priorityId, int resolutionId, string title, DateRange activePeriod, string? description = null, string? comments = null)
    {
        if ((object)assetId is null)
        {
            throw new BusinessRuleExceptions($"{nameof(assetId)} is required.");
        }

        if ((object)employeeId is null)
        {
            throw new BusinessRuleExceptions($"{nameof(employeeId)} is required.");
        }

        if ((object)ticketStatusId is null)
        {
            throw new BusinessRuleExceptions($"{nameof(ticketStatusId)} is required.");
        }

        if ((object)priorityId is null)
        {
            throw new BusinessRuleExceptions($"{nameof(priorityId)} is required.");
        }

        if ((object)resolutionId is null)
        {
            throw new BusinessRuleExceptions($"{nameof(resolutionId)} is required.");
        }

        if (string.IsNullOrWhiteSpace(title))
        {
            throw new BusinessRuleExceptions($"{nameof(title)} is required.");
        }

        
        AssetId = assetId;
        EmployeeId = employeeId;
        TicketStatusId = ticketStatusId;
        PriorityId = priorityId;
        ResolutionId = resolutionId;
        Title = title;
        ActivePeriod = activePeriod;
        Description = description;
        Comments = comments;
    }
}
