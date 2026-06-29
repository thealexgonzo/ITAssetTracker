using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Roles.Commands.UpdateRole
{
    public class UpdateRoleCommandValidator: AbstractValidator<UpdateRoleCommand>
    {
        public UpdateRoleCommandValidator()
        {
            RuleFor(role => role.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
