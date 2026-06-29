using FluentValidation;

namespace ITAssetTracker.Application.Services.Manufacturers.Commands.CreateManufacturer;

public class CreateManufacturerCommandValidator: AbstractValidator<CreateManufacturerCommand>
{
    public CreateManufacturerCommandValidator()
    {
        RuleFor(manufacturer => manufacturer.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
    }
}
