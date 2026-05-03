namespace ITAssetTracker.Infrastructure.Entities;

public class SupportTicket
{
    public int SupportTicketId { get; set; }
    public int AssetAssignmentId { get; set; }
    public int StatusId { get; set; }
    public int PriorityId { get; set; }
    public int ResolutionId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Comments { get; set; }
    public int UserId { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? CloseDate { get; set; }

    public User User { get; set; } = null!;
    public AssetAssignment AssetAssignment { get; set; } = null!;
    public Status Status { get; set; } = null!;
    public Priority Priority { get; set; } = null!;
    public Resolution Resolution { get; set; } = null!;
}
