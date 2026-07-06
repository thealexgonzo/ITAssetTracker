using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Departments.Queries.GetDepartmentDetails
{
    public class GetDepartmentDetailsQuery: IRequest<DepartmentDetailsViewModel>
    {
        public int Id { get; set; }
    }
}
