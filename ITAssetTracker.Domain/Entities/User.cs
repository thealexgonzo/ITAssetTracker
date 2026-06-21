using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Exceptions;

namespace ITAssetTracker.Domain.Entities;

public class User: AuditableEntity
{
    public string UserName { get; private set; } = string.Empty;
    public string PasswordHash { get; private set; } = string.Empty;
    public Guid RoleId { get; private set; }
    public Role Role { get; set; } = null!;
    public List<SupportTicket> SupportTickets { get; set; } = new();
    public Employee Employee { get; set; } = null!;

    public User(string userName, string passwordHash, Guid roleId)
    {
        if (string.IsNullOrWhiteSpace(userName))
        {
            throw new BusinessRuleExceptions($"{nameof(userName)} is required.");
        }

        if (string.IsNullOrWhiteSpace(passwordHash))
        {
            throw new BusinessRuleExceptions($"{nameof(passwordHash)} is required.");
        }

        if((object)roleId is null)
        {
            throw new BusinessRuleExceptions($"{nameof(roleId)} is required.");
        }

        Id = Guid.CreateVersion7();
        UserName = userName;
        PasswordHash = passwordHash;
        RoleId = roleId;
    }
}
