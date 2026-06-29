using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Users.Commands.UpdateUser
{
    public class UpdateUserCommandValidator: AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidator()
        {
            RuleFor(user => user.UserName)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(user => user.PasswordHash)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();

            RuleFor(user => user.RoleId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();
        }
    }
}
