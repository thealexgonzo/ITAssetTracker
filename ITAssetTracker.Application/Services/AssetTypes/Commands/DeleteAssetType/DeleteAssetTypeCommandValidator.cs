using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetTypes.Commands.DeleteAssetType
{
    public class DeleteAssetTypeCommandValidator: AbstractValidator<DeleteAssetTypeCommand>
    {
        public DeleteAssetTypeCommandValidator()
        {
            RuleFor(assetType => assetType.Id)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}
