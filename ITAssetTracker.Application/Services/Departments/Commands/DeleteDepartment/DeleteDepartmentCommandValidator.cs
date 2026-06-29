using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Departments.Commands.DeleteDepartment
{
    public class DeleteDepartmentCommandValidator: AbstractValidator<DeleteDepartmentCommand>
    {
        public DeleteDepartmentCommandValidator()
        {
            RuleFor(department => department.Id)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
        }
    }
}
