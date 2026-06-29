using MediatR;

namespace ITAssetTracker.Application.Services.Priorities.Commands.DeletePriorities;

public class DeletePrioritiesCommand: IRequest
{
    public Guid Id { get; set; }
}
