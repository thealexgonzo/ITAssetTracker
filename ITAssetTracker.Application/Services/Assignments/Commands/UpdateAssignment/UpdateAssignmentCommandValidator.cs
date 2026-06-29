using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Assignments.Commands.UpdateAssignment
{
    public class UpdateAssignmentCommandValidator: AbstractValidator<UpdateAssignmentCommand>
    {
        public UpdateAssignmentCommandValidator()
        {
            RuleFor(assetAssignment => assetAssignment.AssetId)
                    .NotEmpty().WithMessage("{PropertyName} is required.")
                    .NotNull();

            RuleFor(assetAssignment => assetAssignment.EmployeeId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(assetAssignment => assetAssignment.AssignmentPeriod.start)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}
