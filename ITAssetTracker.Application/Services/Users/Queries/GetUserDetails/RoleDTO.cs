using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Users.Queries.GetUserDetails
{
    public class RoleDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
