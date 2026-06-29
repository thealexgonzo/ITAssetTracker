using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Manufacturers.Commands.DeleteManufacturer
{
    public class DeleteManufacturerCommandValidator: AbstractValidator<DeleteManufacturerCommand>
    {
        public DeleteManufacturerCommandValidator()
        {
            RuleFor(manufacturer => manufacturer.Id)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}
