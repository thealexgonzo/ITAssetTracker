using FluentValidation;

namespace ITAssetTracker.Application.Services.Employees.Commands.DeleteEmployee;

public class DeleteEmployeeCommandValidator: AbstractValidator<DeleteEmployeeCommand>
{
    public DeleteEmployeeCommandValidator()
    {
        RuleFor(employee => employee.Id)
            .NotNull()
            .NotEmpty().WithMessage("{PropertyName} is required.");
    }
}
