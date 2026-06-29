using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Employees.Queries.GetEmployeesList
{
    public class GetEmployeeListQuery: IRequest<List<EmployeeListViewModel>>
    {
    }
}
