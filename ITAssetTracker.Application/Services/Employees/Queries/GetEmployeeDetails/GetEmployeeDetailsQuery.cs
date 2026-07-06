using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Employees.Queries.GetEmployeeDetails
{
    public class GetEmployeeDetailsQuery: IRequest<EmployeeDetailsViewModel>
    {
        public int Id { get; set; }
    }
}
