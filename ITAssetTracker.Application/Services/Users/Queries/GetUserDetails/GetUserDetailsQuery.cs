using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Users.Queries.GetUserDetails
{
    public class GetUserDetailsQuery: IRequest<UserDetailsViewModel>
    {
        public int Id { get; set; }
    }
}
