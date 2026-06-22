using FluentValidation;

namespace ITAssetTracker.Application.Services.AssetProducts.Commands.DeleteAssetProduct;

public class DeleteAssetProductCommandValidator: AbstractValidator<DeleteAssetProductCommand>
{
    public DeleteAssetProductCommandValidator()
    {
        RuleFor(assetProduct => assetProduct.Id)
            .NotNull()
            .NotEmpty().WithMessage("{PropertyName} is required.");
    }
}
