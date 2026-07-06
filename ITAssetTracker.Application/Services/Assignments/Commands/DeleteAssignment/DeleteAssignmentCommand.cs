using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Assignments.Commands.DeleteAssignment
{
    public class DeleteAssignmentCommand: IRequest
    {
        public int Id { get; set; }
    }
}
