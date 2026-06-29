using MediatR;

namespace ITAssetTracker.Application.Services.Users.Commands.CreateUser
{
    public class CreateUserCommand: IRequest<Guid>
    {
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public Guid RoleId { get; private set; }
    }
}
