using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Exceptions;

namespace ITAssetTracker.Domain.Entities;

public class Department: AuditableEntity
{
    public string Name { get; private set; } = null!;
    public List<Employee> Employees { get; set; } = new();

    public Department(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new BusinessRuleExceptions($"{nameof(name)} is required.");
        }

        
        Name = name;
    }
}
