using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Exceptions;
using ITAssetTracker.Domain.ValueObjects;

namespace ITAssetTracker.Domain.Entities;

public class Employee: AuditableEntity
{
    public int UserId { get; private set; }
    public User User { get; set; } = null!;
    public string JobTitle { get; private set; } = string.Empty;
    public string FirstName { get; private set; } = string.Empty;
    public string? MiddleName { get; private set; }
    public string LastName { get; private set; } = string.Empty;
    public DateOnly DoB { get; private set; }
    public Email Email { get; private set; }
    public Phone Phone { get; private set; }
    public DateRange EmploymentPeriod { get; private set; }
    public int DepartmentId { get; private set; }
    public Department Department { get; set; } = null!;
    public List<AssetAssignment> AssetAssignments { get; set; } = new();

    public Employee(int userId, string jobTitle, string firstName, string lastName, DateOnly dob, Email email, Phone phone, DateRange employmentPeriod, int departmentId, string? middleName = null)
    {
        if((object)userId is null)
        {
            throw new BusinessRuleExceptions($"{nameof(userId)} is required.");
        }

        if((object)departmentId is null)
        {
            throw new BusinessRuleExceptions($"{nameof(departmentId)} is required.");
        }

        if(dob < dob.AddYears(-18))
        {
            throw new BusinessRuleExceptions($"Employee must be over 18 years old.");
        }


        
        UserId = userId;
        JobTitle = jobTitle;
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        DoB = dob;
        Email = email;
        Phone = phone;
        EmploymentPeriod = employmentPeriod;
        DepartmentId = departmentId;
    }
}
