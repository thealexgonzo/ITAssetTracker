using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.ValueObjects;

namespace ITAssetTracker.Domain.Entities;

public class AssetAssignment: AuditableEntity
{
    public Guid AssetId { get; private set; }
    public Asset Asset { get; set; } = null!;
    public Guid EmployeeId { get; private set; }
    public Employee Employee { get; set; } = null!;
    public DateRange AssignmentPeriod { get; private set; } // TODO: Configure these properties in the Persistence layer.

    public AssetAssignment(Guid assetId, Guid employeeId, DateRange assignmentPeriod)
    {
        Id = Guid.CreateVersion7();
        AssetId = assetId;
        EmployeeId = employeeId;
        AssignmentPeriod = assignmentPeriod;
    }
}
