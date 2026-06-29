using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Priorities.Commands.UpdatePriorities
{
    public class UpdatePrioritiesCommandValidator: AbstractValidator<UpdatePrioritiesCommand>
    {
        public UpdatePrioritiesCommandValidator()
        {
            RuleFor(priority => priority.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
