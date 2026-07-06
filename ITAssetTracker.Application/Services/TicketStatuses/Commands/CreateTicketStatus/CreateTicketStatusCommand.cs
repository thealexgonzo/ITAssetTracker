using MediatR;

namespace ITAssetTracker.Application.Services.TicketStatuses.Commands.CreateTicketStatus;

public class CreateTicketStatusCommand: IRequest<int>
{
    public string Name { get; set; } = string.Empty;
}
