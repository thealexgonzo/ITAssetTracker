using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Users.Queries.GetUsersList
{
    public class GetUserListQuery: IRequest<List<UserListViewModel>>
    {
    }
}
