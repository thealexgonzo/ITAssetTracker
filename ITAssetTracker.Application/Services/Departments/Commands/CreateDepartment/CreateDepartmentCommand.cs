using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Departments.Commands.CreateDepartment
{
    public class CreateDepartmentCommand: IRequest<int>
    {
        public string Name { get; set; } = null!;
    }
}
