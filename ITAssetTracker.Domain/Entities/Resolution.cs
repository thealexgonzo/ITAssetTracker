namespace ITAssetTracker.Domain.Entities;

public class Resolution
{
    public int ResolutionId { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<SupportTicket> SupportTickets { get; set; } = new();
}
