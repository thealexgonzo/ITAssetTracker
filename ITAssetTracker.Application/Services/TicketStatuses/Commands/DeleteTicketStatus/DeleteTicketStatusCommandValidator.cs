using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.TicketStatuses.Commands.DeleteTicketStatus
{
    public class DeleteTicketStatusCommandValidator: AbstractValidator<DeleteTicketStatusCommand>
    {
        public DeleteTicketStatusCommandValidator()
        {
            RuleFor(ticketStatus => ticketStatus.Id)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
        }
    }
}
