using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetTypes.Commands.CreateAssetType
{
    public class CreateAssetTypeCommandValidator: AbstractValidator<CreateAssetTypeCommand>
    {
        public CreateAssetTypeCommandValidator()
        {
            RuleFor(assetType => assetType.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(assetType => assetType.CategoryId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}
