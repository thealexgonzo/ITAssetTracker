using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Domain.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Assignments.Commands.CreateAssignment
{
    public class CreateAssignmentCommand: IRequest<Guid>
    {
        public Guid AssetId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateRange AssignmentPeriod { get; set; } = null!; // TODO: Configure these properties in the Persistence layer.
    }
}
