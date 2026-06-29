using FluentValidation;

namespace ITAssetTracker.Application.Services.Priorities.Commands.CreatePriorities;

public class CreatePrioritiesCommandValidator: AbstractValidator<CreatePrioritiesCommand>
{
    public CreatePrioritiesCommandValidator()
    {
        RuleFor(priority => priority.Name)
        .NotEmpty().WithMessage("{PropertyName} is required.")
        .NotNull()
        .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
    }
}
