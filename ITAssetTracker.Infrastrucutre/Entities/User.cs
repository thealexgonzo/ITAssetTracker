namespace ITAssetTracker.Infrastructure.Entities;

public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public int RoleId { get; set; }

    public List<SupportTicket> SupporTickets { get; set; } = new();
    public Employee Employee { get; set; } = null!;
    public Role Role { get; set; }
}
