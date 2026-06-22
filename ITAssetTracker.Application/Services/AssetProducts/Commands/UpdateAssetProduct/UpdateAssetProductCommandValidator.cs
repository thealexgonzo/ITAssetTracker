using FluentValidation;

namespace ITAssetTracker.Application.Services.AssetProducts.Commands.UpdateAssetProduct;

public class UpdateAssetProductCommandValidator: AbstractValidator<UpdateAssetProductCommand>
{
    public UpdateAssetProductCommandValidator()
    {
        RuleFor(assetProduct => assetProduct.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

        RuleFor(assetProduct => assetProduct.AssetTypeId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();

        RuleFor(assetProduct => assetProduct.ManufacturerId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();
    }
}
