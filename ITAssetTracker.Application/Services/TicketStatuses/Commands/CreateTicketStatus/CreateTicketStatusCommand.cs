using MediatR;

namespace ITAssetTracker.Application.Services.TicketStatuses.Commands.CreateTicketStatus;

public class CreateTicketStatusCommand: IRequest<Guid>
{
    public string Name { get; set; } = string.Empty;
}
