using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Domain.ValueObjects;
using MediatR;

namespace ITAssetTracker.Application.Services.Employees.Commands.CreateEmployee;

public class CreateEmployeeCommand: IRequest<Guid>
{
    public Guid UserId { get; set; }
    public string JobTitle { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string? MiddleName { get; set; }
    public string LastName { get; set; } = string.Empty;
    public DateOnly DoB { get; set; }
    public Email Email { get; set; } = null!;
    public Phone Phone { get; set; } = null!;
    public DateRange EmploymentPeriod { get; set; } = null!;
    public Guid DepartmentId { get; set; }
    public Department Department { get; set; } = null!;
}
