using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Departments.Commands.UpdateDepartment;

public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand>
{
    private readonly IDepartmentRepository departmentRepository;
    private readonly IMapper mapper;

    public UpdateDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMapper mapper)
    {
        this.departmentRepository = departmentRepository;
        this.mapper = mapper;
    }

    public async Task Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
    {
        Department? departmentToUpdate = await departmentRepository.GetByIdAsync(request.Id);

        if (departmentToUpdate is null)
        {
            throw new NotFoundException("Asset", request.Id);
        }

        UpdateDepartmentCommandValidator validator = new UpdateDepartmentCommandValidator();
        ValidationResult validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        mapper.Map(request, departmentToUpdate, typeof(UpdateDepartmentCommand), typeof(Department));
        await departmentRepository.UpdateAsync(departmentToUpdate); // TODO: Need to add validation, the asset cannot be null if you want to update it
    }
}
