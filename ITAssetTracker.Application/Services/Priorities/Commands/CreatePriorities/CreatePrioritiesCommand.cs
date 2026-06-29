using MediatR;

namespace ITAssetTracker.Application.Services.Priorities.Commands.CreatePriorities;

public class CreatePrioritiesCommand: IRequest<Guid>
{
    public string Name { get; set; } = string.Empty;
}
