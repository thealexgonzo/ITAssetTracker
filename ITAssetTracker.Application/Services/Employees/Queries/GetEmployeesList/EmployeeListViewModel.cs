using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Employees.Queries.GetEmployeesList
{
    public class EmployeeListViewModel
    {
        public Guid Id { get; set; }
        public string JobTitle { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = string.Empty;
    }
}
