using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Users.Commands.DeleteUser
{
    public class DeleteUserCommandValidator: AbstractValidator<DeleteUserCommand>
    {
        public DeleteUserCommandValidator()
        {
            RuleFor(user => user.Id)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
        }
    }
}
