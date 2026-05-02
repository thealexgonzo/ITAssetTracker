namespace ITAssetTracker.DataAccess.Entities;

public class Employee
{
    public int EmployeeId { get; set; }
    public int UserId { get; set; }
    public string JobTitle { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime DoB { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateTime HireDate { get; set; }
    public DateTime? TerminationDate { get; set; }

    public User User { get; set; } = null!;
    public List<AssetAssignment> AssetAssignments { get; set; } = new();
}
