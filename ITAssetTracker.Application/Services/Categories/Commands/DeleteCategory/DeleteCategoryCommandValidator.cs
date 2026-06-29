using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Categories.Commands.DeleteCategory
{
    public class DeleteCategoryCommandValidator: AbstractValidator<DeleteCategoryCommand>
    {
        public DeleteCategoryCommandValidator()
        {
            RuleFor(asset => asset.Id)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
        }
    }
}
