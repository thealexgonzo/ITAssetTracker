using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Resolutions.Commands.CreateResolution
{
    public class CreateResolutionCommandValidator: AbstractValidator<CreateResolutionCommand>
    {
        public CreateResolutionCommandValidator()
        {
            RuleFor(resolution => resolution.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
