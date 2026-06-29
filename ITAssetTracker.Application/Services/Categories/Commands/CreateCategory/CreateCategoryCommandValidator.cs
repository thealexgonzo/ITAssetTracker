using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandValidator: AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(category => category.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
