using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetStatuses.Commands.UpdateAssetStatus
{
    public class UpdateAssetStatusCommandValidator: AbstractValidator<UpdateAssetStatusCommand>
    {
        public UpdateAssetStatusCommandValidator()
        {
            RuleFor(assetStatus => assetStatus.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();
        }
    }
}
