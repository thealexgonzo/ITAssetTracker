using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Roles.Commands.CreateRole
{
    public class CreateRoleCommandValidator: AbstractValidator<CreateRoleCommand>
    {
        public CreateRoleCommandValidator()
        {
            RuleFor(role => role.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
