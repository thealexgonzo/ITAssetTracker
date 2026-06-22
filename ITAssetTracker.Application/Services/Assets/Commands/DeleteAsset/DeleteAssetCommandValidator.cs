using FluentValidation;

namespace ITAssetTracker.Application.Services.Assets.Commands.DeleteAsset;

public class DeleteAssetCommandValidator: AbstractValidator<DeleteAssetCommand>
{
    public DeleteAssetCommandValidator()
    {
        RuleFor(asset => asset.Id)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");        
    }
}
