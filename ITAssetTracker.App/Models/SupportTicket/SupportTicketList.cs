namespace ITAssetTracker.WebAPI.Models.SupportTicket;

public class SupportTicketList
{
    public int? SearchId { get; set; }
    public IEnumerable<Domain.Entities.SupportTicket>? SupportTickets { get; set; }
}
