using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Domain.ValueObjects;

namespace ITAssetTracker.Application.Services.Assignments.Queries.GetAssignmentsList;

public class AssignmentListViewModel
{
    public int Id { get; set; }
    public int AssetId { get; set; }
    public int EmployeeId { get; set; }
    public DateRange AssignmentPeriod { get; set; } = null!; // TODO: Configure these properties in the Persistence layer.
}
