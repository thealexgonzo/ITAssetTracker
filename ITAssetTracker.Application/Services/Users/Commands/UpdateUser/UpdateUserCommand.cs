using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Users.Commands.UpdateUser
{
    public class UpdateUserCommand: IRequest
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public Guid RoleId { get; set; }

    }
}
