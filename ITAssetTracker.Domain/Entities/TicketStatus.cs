namespace ITAssetTracker.Domain.Entities;

public class TicketStatus
{
    public int TicketStatusId { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<SupportTicket> SupporTickets { get; set; } = new();
}
