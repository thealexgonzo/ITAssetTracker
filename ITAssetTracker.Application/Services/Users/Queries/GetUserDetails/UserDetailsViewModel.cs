using ITAssetTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Users.Queries.GetUserDetails
{
    public class UserDetailsViewModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public Guid RoleId { get; set; }
        public Role Role { get; set; } = null!;
    }
}
