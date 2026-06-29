using FluentValidation;
using ITAssetTracker.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Commands.DeleteSupportTicket
{
    public class DeleteSupportTicketCommandValidator: AbstractValidator<DeleteSupportTicketCommand>
    {
        public DeleteSupportTicketCommandValidator()
        {
            RuleFor(supportTicket => supportTicket.Id)
                .NotEmpty()
                .NotNull();
        }
    }
}