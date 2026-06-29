using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using MediatR;

namespace ITAssetTracker.Application.Services.Employees.Queries.GetEmployeesList;

public class GetEmployeeListQueryHandler : IRequestHandler<GetEmployeeListQuery, List<EmployeeListViewModel>>
{
    private readonly IEmployeeRepository employeeRepository;
    private readonly IMapper mapper;

    public GetEmployeeListQueryHandler(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        this.employeeRepository = employeeRepository;
        this.mapper = mapper;
    }
    public async Task<List<EmployeeListViewModel>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
    {
        var allEmployees = (await employeeRepository.ListAllAsync()).ToList();
        return mapper.Map<List<EmployeeListViewModel>>(allEmployees);
    }
}
