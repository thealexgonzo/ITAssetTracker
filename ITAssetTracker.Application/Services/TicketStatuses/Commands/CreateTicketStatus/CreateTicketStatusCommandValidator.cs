using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.TicketStatuses.Commands.CreateTicketStatus
{
    public class CreateTicketStatusCommandValidator: AbstractValidator<CreateTicketStatusCommand>
    {
        public CreateTicketStatusCommandValidator()
        {
            RuleFor(ticketStatus => ticketStatus.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
