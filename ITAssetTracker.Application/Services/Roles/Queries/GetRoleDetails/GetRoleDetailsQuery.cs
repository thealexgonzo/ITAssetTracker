using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Roles.Queries.GetRoleDetails
{
    public class GetRoleDetailsQuery: IRequest<RoleDetailsViewModel>
    {
        public Guid Id { get; set; }
    }
}
