using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Roles.Queries.GetRolesList
{
    public class GetRoleListQuery: IRequest<List<RoleListViewModel>>
    {
    }
}
