using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Departments.Queries.GetDepartmentsList
{
    public class GetDepartmentListQuery: IRequest<List<DepartmentListViewModel>>
    { 
    }
}
