namespace ITAssetTracker.MVC.Models.SupportTicket;

public class SupportTicketList
{
    public int? SearchId { get; set; }
    public IEnumerable<Infrastructure.Entities.SupportTicket>? SupportTickets { get; set; }
}
