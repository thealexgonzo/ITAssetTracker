using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Assignments.Queries.GetAssignmentsList;

public class GetAssignmentListQueryHandler : IRequestHandler<GetAssignmentListQuery, List<AssignmentListViewModel>>
{
    private readonly IAssetAssignmentRepository assetAssignmentRepository;
    private readonly IAssetRepository assetRepository;
    private readonly IEmployeeRepository employeeRepository;
    private readonly IMapper mapper;

    public GetAssignmentListQueryHandler(IAssetAssignmentRepository assetAssignmentRepository, IAssetRepository assetRepository, IEmployeeRepository employeeRepository,
        IMapper mapper)
    {
        this.assetAssignmentRepository = assetAssignmentRepository;
        this.assetRepository = assetRepository;
        this.employeeRepository = employeeRepository;
        this.mapper = mapper;
    }

    public async Task<List<AssignmentListViewModel>> Handle(GetAssignmentListQuery request, CancellationToken cancellationToken)
    {
        List<AssetAssignment> allAssetAssignments = (await assetAssignmentRepository.ListAllAsync()).ToList();

        return mapper.Map<List<AssignmentListViewModel>>(allAssetAssignments);
    }
}
