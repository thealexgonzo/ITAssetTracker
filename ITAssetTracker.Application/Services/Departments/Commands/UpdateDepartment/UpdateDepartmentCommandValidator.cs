using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Departments.Commands.UpdateDepartment
{
    public class UpdateDepartmentCommandValidator: AbstractValidator<UpdateDepartmentCommand>
    {
        public UpdateDepartmentCommandValidator()
        {
            RuleFor(department => department.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
