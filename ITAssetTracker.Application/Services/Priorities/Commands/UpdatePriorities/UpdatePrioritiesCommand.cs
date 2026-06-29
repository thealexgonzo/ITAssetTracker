using MediatR;

namespace ITAssetTracker.Application.Services.Priorities.Commands.UpdatePriorities;

public class UpdatePrioritiesCommand: IRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
