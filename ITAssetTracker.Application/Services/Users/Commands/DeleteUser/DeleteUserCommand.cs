using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Users.Commands.DeleteUser
{
    public class DeleteUserCommand: IRequest
    {
        public int Id { get; set; }
    }
}
