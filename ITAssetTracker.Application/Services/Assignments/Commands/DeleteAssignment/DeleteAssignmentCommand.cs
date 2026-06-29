using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Assignments.Commands.DeleteAssignment
{
    public class DeleteAssignmentCommand: IRequest
    {
        public Guid Id { get; set; }
    }
}
