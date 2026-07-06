using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.ValueObjects;

namespace ITAssetTracker.Domain.Entities;

public class AssetAssignment: AuditableEntity
{
    public int AssetId { get; private set; }
    public Asset Asset { get; set; } = null!;
    public int EmployeeId { get; private set; }
    public Employee Employee { get; set; } = null!;
    public DateRange AssignmentPeriod { get; private set; } // TODO: Configure these properties in the Persistence layer.

    public AssetAssignment(int assetId, int employeeId, DateRange assignmentPeriod)
    {
        
        AssetId = assetId;
        EmployeeId = employeeId;
        AssignmentPeriod = assignmentPeriod;
    }
}
