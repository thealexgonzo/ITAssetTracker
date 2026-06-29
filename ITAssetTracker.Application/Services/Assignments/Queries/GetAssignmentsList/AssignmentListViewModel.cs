using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Domain.ValueObjects;

namespace ITAssetTracker.Application.Services.Assignments.Queries.GetAssignmentsList;

public class AssignmentListViewModel
{
    public Guid Id { get; set; }
    public Guid AssetId { get; set; }
    public Guid EmployeeId { get; set; }
    public DateRange AssignmentPeriod { get; set; } = null!; // TODO: Configure these properties in the Persistence layer.
}
