using FluentValidation;
using ITAssetTracker.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ITAssetTracker.Application.Services.Assignments.Commands.CreateAssignment
{
    public class CreateAssignmentCommandValidator: AbstractValidator<CreateAssignmentCommand>
    {
        public CreateAssignmentCommandValidator()
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
