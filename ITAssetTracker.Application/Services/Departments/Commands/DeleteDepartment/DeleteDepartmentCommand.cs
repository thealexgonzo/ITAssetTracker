using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Departments.Commands.DeleteDepartment
{
    public class DeleteDepartmentCommand: IRequest
    {
        public int Id { get; set; }
    }
}
