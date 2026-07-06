using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Roles.Commands.CreateRole
{
    public class CreateRoleCommand: IRequest<int>
    {
        public string Name { get; set; } = string.Empty;
    }
}
