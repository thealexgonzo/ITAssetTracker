using ITAssetTracker.Domain.ValueObjects;

namespace ITAssetTracker.Domain.Entities;

public class Employee
{
    public Guid EmployeeId { get; set; }
    public Guid UserId { get; set; }
    public string JobTitle { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime DoB { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateRange DateRange { get; private set; }
    public DateTime HireDate { get; set; }
    public DateTime? TerminationDate { get; set; }
    public int DepartmentId { get; set; }
    public User User { get; set; } = null!;
    public Department Department { get; set; } = null!;
    public List<AssetAssignment> AssetAssignments { get; set; } = new();

    public Employee()
    {

    }
}
