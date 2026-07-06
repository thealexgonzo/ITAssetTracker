using MediatR;

namespace ITAssetTracker.Application.Services.Priorities.Commands.DeletePriorities;

public class DeletePrioritiesCommand: IRequest
{
    public int Id { get; set; }
}
