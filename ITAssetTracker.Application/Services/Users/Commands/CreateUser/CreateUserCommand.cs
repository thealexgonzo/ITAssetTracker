using MediatR;

namespace ITAssetTracker.Application.Services.Users.Commands.CreateUser
{
    public class CreateUserCommand: IRequest<int>
    {
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public int RoleId { get; private set; }
    }
}
