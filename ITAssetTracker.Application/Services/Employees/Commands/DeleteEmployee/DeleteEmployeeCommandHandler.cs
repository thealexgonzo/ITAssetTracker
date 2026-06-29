using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using MediatR;

namespace ITAssetTracker.Application.Services.Employees.Commands.DeleteEmployee;

public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand>
{
    private readonly IEmployeeRepository employeeRepository;
    private readonly IMapper mapper;

    public DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        this.employeeRepository = employeeRepository;
        this.mapper = mapper;
    }
    public async Task Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
    {
        var employeeToDelete = await employeeRepository.GetByIdAsync(request.Id);

        if (employeeToDelete is null)
        {
            throw new NotFoundException("Employee", request.Id);
        }

        await employeeRepository.DeleteAsync(employeeToDelete);
    }
}
