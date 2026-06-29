using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Employees.Queries.GetEmployeeDetails
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
    }
}
