namespace ITAssetTracker.Domain.Entities;

public class Department
{
    public Guid DepartmentId { get; set; }
    public string Name { get; set; } = null!;
    public List<Employee> Employees { get; set; } = new();
}
