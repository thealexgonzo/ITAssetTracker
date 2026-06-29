using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Domain.ValueObjects;

namespace ITAssetTracker.Application.Services.Assignments.Queries.GetAssignmentDetails;

public class AssignmentDetailsViewModel
{
    public Guid Id { get; set; }
    public Guid AssetId { get; set; }
    public Asset Asset { get; set; } = null!;
    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;
    public DateRange AssignmentPeriod { get; set; } = null!; // TODO: Configure these properties in the Persistence layer.
}
