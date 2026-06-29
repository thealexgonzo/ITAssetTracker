using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Roles.Commands.UpdateRole
{
    public class UpdateRoleCommand: IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
