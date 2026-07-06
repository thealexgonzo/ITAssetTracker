using ITAssetTracker.Domain.ValueObjects;
using MediatR;

namespace ITAssetTracker.Application.Services.SupporTickets.Commands.CreateSupportTicket;

public class CreateSupportTicketCommand: IRequest<int>
{
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
