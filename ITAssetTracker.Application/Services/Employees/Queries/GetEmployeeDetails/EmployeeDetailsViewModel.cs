using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Employees.Queries.GetEmployeeDetails
{
    public class EmployeeDetailsViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string JobTitle { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public DateOnly DoB { get; set; }
        public Email Email { get; set; } = null!;
        public Phone Phone { get; set; } = null!;
        public DateRange EmploymentPeriod { get; set; } = null!;
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;
    }
}
