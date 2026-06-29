using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Departments.Commands.CreateDepartment
{
    public class CreateDepartmentCommandValidator: AbstractValidator<CreateDepartmentCommand>
    {
        public CreateDepartmentCommandValidator()
        {
            RuleFor(department => department.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
