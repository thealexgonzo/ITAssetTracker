using ITAssetTracker.Domain.ValueObjects;
using MediatR;

namespace ITAssetTracker.Application.Services.SupporTickets.Commands.CreateSupportTicket;

public class CreateSupportTicketCommand: IRequest<Guid>
{
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
