using FluentValidation;

namespace ITAssetTracker.Application.Services.Employees.Commands.CreateEmployee;

public class CreateEmployeeCommandValidator: AbstractValidator<CreateEmployeeCommand>
{
    public CreateEmployeeCommandValidator()
    {
        RuleFor(employee => employee.UserId)
            .NotNull().WithMessage("{PropertyName} is required.")
            .NotEmpty();

        RuleFor(employee => employee.JobTitle)
            .NotNull().WithMessage("{PropertyName} is required.")
            .NotEmpty()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

        RuleFor(employee => employee.FirstName)
            .NotNull().WithMessage("{PropertyName} is required.")
            .NotEmpty()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

        RuleFor(employee => employee.MiddleName)
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

        RuleFor(employee => employee.LastName)
            .NotNull().WithMessage("{PropertyName} is required.")
            .NotEmpty()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

        RuleFor(employee => employee.DoB)
            .NotNull().WithMessage("{PropertyName} is required.")
            .NotEmpty();

        RuleFor(employee => employee.Email)
            .NotNull().WithMessage("{PropertyName} is required.")
            .NotEmpty();

        RuleFor(employee => employee.Phone)
            .NotNull().WithMessage("{PropertyName} is required.")
            .NotEmpty();

        RuleFor(employee => employee.EmploymentPeriod.start)
            .NotNull().WithMessage("{PropertyName} is required.")
            .NotEmpty();

        RuleFor(employee => employee.DepartmentId)
            .NotNull().WithMessage("{PropertyName} is required.")
            .NotEmpty();
    }
}
