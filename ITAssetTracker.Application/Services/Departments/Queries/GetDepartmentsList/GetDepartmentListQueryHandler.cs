using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Departments.Queries.GetDepartmentsList;

public class GetDepartmentListQueryHandler : IRequestHandler<GetDepartmentListQuery, List<DepartmentListViewModel>>
{
    private readonly IDepartmentRepository departmentRepository;
    private readonly IMapper mapper;

    public GetDepartmentListQueryHandler(IDepartmentRepository departmentRepository, IMapper mapper)
    {
        this.departmentRepository = departmentRepository;
        this.mapper = mapper;
    }

    public async Task<List<DepartmentListViewModel>> Handle(GetDepartmentListQuery request, CancellationToken cancellationToken)
    {
        List<Department> allDepartments = (await departmentRepository.ListAllAsync()).ToList();

        return mapper.Map<List<DepartmentListViewModel>>(allDepartments);
    }
}
