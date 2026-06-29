using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Employees.Commands.UpdateEmployee;

public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
{
    private readonly IEmployeeRepository employeeRepository;
    private readonly IMapper mapper;

    public UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        this.employeeRepository = employeeRepository;
        this.mapper = mapper;
    }
    public async Task Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
    {
        Employee? employeeToUpdate = await employeeRepository.GetByIdAsync(request.Id);

        if (employeeToUpdate is null)
        {
            throw new NotFoundException("Asset", request.Id);
        }

        UpdateEmployeeCommandValidator validator = new UpdateEmployeeCommandValidator();
        ValidationResult validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        mapper.Map(request, employeeToUpdate, typeof(UpdateEmployeeCommand), typeof(Employee));
        await employeeRepository.UpdateAsync(employeeToUpdate); // TODO: Need to add validation, the asset cannot be null if you want to update it
    }
}
