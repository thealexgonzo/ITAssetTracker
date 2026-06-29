using FluentValidation;
using ITAssetTracker.Application.Services.Priorities.Commands.DeletePriorities;

namespace ITAssetTracker.Application.Services.Priorities.Commands;

public class DeletePrioritiesCommandValidator: AbstractValidator<DeletePrioritiesCommand>
{
    public DeletePrioritiesCommandValidator()
    {
        RuleFor(priority => priority.Id)
            .NotEmpty()
            .NotNull();
    }
}
