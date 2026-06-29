using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Employees.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommand: IRequest
    {
        public Guid Id { get; set; }
    }
}
