using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Roles.Commands.DeleteRole
{
    public class DeleteRoleCommand: IRequest
    {
        public Guid Id { get; set; }
    }
}
