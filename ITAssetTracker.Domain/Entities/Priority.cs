namespace ITAssetTracker.Domain.Entities;

public class Priority
{
    public int PriorityId { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<SupportTicket> SupportTickets { get; set; } = new();
}
