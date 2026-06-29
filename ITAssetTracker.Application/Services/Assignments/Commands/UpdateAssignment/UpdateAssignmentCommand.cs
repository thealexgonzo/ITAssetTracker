using ITAssetTracker.Domain.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Assignments.Commands.UpdateAssignment
{
    public class UpdateAssignmentCommand: IRequest
    {
        public Guid Id { get; set; }
        public Guid AssetId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateRange AssignmentPeriod { get; set; } = null!; // TODO: Configure these properties in the Persistence layer.
    }
}
