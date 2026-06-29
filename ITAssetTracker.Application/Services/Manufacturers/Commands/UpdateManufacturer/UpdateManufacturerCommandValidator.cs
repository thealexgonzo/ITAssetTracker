using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Manufacturers.Commands.UpdateManufacturer
{
    public class UpdateManufacturerCommandValidator: AbstractValidator<UpdateManufacturerCommand>
    {
        public UpdateManufacturerCommandValidator()
        {
            RuleFor(manufacturer => manufacturer.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
