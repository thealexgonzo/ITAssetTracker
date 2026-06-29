using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Resolutions.Commands.UpdateResolution
{
    public class UpdateResolutionCommandValidator: AbstractValidator<UpdateResolutionCommand>
    {
        public UpdateResolutionCommandValidator()
        {
            RuleFor(resolution => resolution.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
