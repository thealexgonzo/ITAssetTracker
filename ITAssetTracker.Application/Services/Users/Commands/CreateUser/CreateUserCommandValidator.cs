using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Users.Commands.CreateUser
{
    public class CreateUserCommandValidator: AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(asset => asset.UserName)
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
