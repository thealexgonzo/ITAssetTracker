namespace ITAssetTracker.Domain.Entities;

public class TicketAssignmentHistory
{
    public int TicketAssignmentHistoryId { get; set; }
    public int SupportTicketId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime AssignedDate { get; set; }
    public DateTime? UnassignedDate { get; set; }
    public SupportTicket SupportTicket { get; set; } = null!;
}
