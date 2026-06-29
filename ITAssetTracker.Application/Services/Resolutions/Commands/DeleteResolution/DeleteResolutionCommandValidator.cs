using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Resolutions.Commands.DeleteResolution
{
    public class DeleteResolutionCommandValidator: AbstractValidator<DeleteResolutionCommand>
    {
        public DeleteResolutionCommandValidator()
        {
            RuleFor(resolution => resolution.Id)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
        }
    }
}
