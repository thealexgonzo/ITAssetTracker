using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Departments.Queries.GetDepartmentDetails
{
    public class DepartmentDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
