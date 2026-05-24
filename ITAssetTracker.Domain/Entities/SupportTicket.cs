namespace ITAssetTracker.Domain.Entities;

public class SupportTicket
{
    public int SupportTicketId { get; set; }
    public int AssetId { get; set; }
    public int EmployeeId { get; set; }
    public int TicketStatusId { get; set; }
    public int PriorityId { get; set; }
    public int ResolutionId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Comments { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? ClosedDate { get; set; }
    public Asset Asset { get; set; } = null!;
    public Employee Employee { get; set; } = null!;
    public TicketStatus TicketStatus { get; set; } = null!;
    public Priority Priority { get; set; } = null!;
    public Resolution Resolution { get; set; } = null!;
    public List<TicketAssignmentHistory> TicketAssignmentHistories { get; set; } = new();
}
