using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Commands.UpdateSupportTicket
{
    public class UpdateSupportTicketCommandValidator: AbstractValidator<UpdateSupportTicketCommand>
    {
        public UpdateSupportTicketCommandValidator()
        {
            RuleFor(supportTicket => supportTicket.Title)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(supportTicket => supportTicket.Description)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(200).WithMessage("{PropertyName} must not exceed 200 characters.");

            RuleFor(supportTicket => supportTicket.Comments)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(200).WithMessage("{PropertyName} must not exceed 200 characters.");

            RuleFor(supportTicket => supportTicket.AssetId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(supportTicket => supportTicket.TicketStatusId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(supportTicket => supportTicket.PriorityId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(supportTicket => supportTicket.ResolutionId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(supportTicket => supportTicket.Description)
                .MaximumLength(200).WithMessage("{PropertyName} must not exceed 200 characters.");

            RuleFor(supportTicket => supportTicket.EmployeeId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(supportTicket => supportTicket.ActivePeriod.start)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}
