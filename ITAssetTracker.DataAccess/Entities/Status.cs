namespace ITAssetTracker.DataAccess.Entities;

public class Status
{
    public int StatusId { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<SupportTicket> SupporTickets { get; set; } = new();
}
