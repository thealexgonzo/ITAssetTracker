using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetTypes.Commands.UpdateAssetType
{
    public class UpdateAssetTypeCommandValidator: AbstractValidator<UpdateAssetTypeCommand>
    {
        public UpdateAssetTypeCommandValidator()
        {
            RuleFor(assetType => assetType.Id)
                .NotEmpty()
                .NotNull().WithMessage("{PropertyName} is required.");

            RuleFor(assetType => assetType.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
