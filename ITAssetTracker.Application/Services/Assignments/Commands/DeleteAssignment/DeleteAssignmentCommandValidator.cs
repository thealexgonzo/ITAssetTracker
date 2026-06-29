using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Assignments.Commands.DeleteAssignment
{
    public class DeleteAssignmentCommandValidator: AbstractValidator<DeleteAssignmentCommand>
    {
        public DeleteAssignmentCommandValidator()
        {
            RuleFor(assetAssignment => assetAssignment.Id)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
        }
    }
}
