using FluentValidation;

namespace ITAssetTracker.Application.Services.AssetStatuses.Commands.CreateAssetStatus;

public class CreateAssetStatusCommandValidator: AbstractValidator<CreateAssetStatusCommand>
{
    public CreateAssetStatusCommandValidator()
    {
        RuleFor(assetStatus => assetStatus.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();
    }
}
