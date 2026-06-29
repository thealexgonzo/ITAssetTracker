using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Employees.Queries.GetEmployeeDetails;

public class GetEmployeeDetailsQueryHandler : IRequestHandler<GetEmployeeDetailsQuery, EmployeeDetailsViewModel>
{
    private readonly IEmployeeRepository employeeRepository;
    private readonly IMapper mapper;

    public GetEmployeeDetailsQueryHandler(IEmployeeRepository employeeRepository, 
        IMapper mapper, IDepartmentRepository departmentRepository, IUserRepository userRepository)
    {
        this.employeeRepository = employeeRepository;
        this.mapper = mapper;
    }

    public async Task<EmployeeDetailsViewModel> Handle(GetEmployeeDetailsQuery request, CancellationToken cancellationToken)
    {
        var employee = await employeeRepository.GetByIdAsync(request.Id)!;

        if (employee is null)
        {
            throw new NotFoundException("Employee", request.Id);
        }

        EmployeeDetailsViewModel employeeDetailsViewModel = mapper.Map<EmployeeDetailsViewModel>(employee);

        var department = await employeeRepository.GetByIdAsync(employee.DepartmentId)!;
        var user = await employeeRepository.GetByIdAsync(employee.UserId)!;

        employeeDetailsViewModel.Department = mapper.Map<Department>(department);
        employeeDetailsViewModel.User = mapper.Map<User>(user);

        return employeeDetailsViewModel;
    }
}
