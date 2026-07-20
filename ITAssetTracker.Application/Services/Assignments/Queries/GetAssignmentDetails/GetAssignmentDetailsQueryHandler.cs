using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Assignments.Queries.GetAssignmentDetails
{
    public class GetAssignmentDetailsQueryHandler : IRequestHandler<GetAssignmentDetailsQuery, AssignmentDetailsViewModel>
    {
        private readonly IAssetAssignmentRepository assetAssignmentRepository;
        private readonly IMapper mapper;
        private readonly IAssetRepository assetRepository;
        private readonly IEmployeeRepository employeeRepository;

        public GetAssignmentDetailsQueryHandler(IAssetAssignmentRepository assetAssignmentRepository, IMapper mapper, 
            IAssetRepository assetRepository, IEmployeeRepository employeeRepository)
        {
            this.assetAssignmentRepository = assetAssignmentRepository;
            this.mapper = mapper;
            this.assetRepository = assetRepository;
            this.employeeRepository = employeeRepository;
        }

        public async Task<AssignmentDetailsViewModel> Handle(GetAssignmentDetailsQuery request, CancellationToken cancellationToken)
        {
            AssetAssignment? assignment = await assetAssignmentRepository.GetByIdAsync(request.Id)!;

            if (assignment is null)
            {
                throw new NotFoundException("Asset Assignment", request.Id);
            }

            AssignmentDetailsViewModel assetAssignmentDetailViewModel = mapper.Map<AssignmentDetailsViewModel>(assignment);

            //Asset? asset = await assetRepository.GetByIdAsync(assignment.AssetId)!;
            //Employee? employee = await employeeRepository.GetByIdAsync(assignment.EmployeeId)!;

            //assetAssignmentDetailViewModel.Asset = mapper.Map<Asset>(asset);
            //assetAssignmentDetailViewModel.Employee = mapper.Map<Employee>(employee);

            return assetAssignmentDetailViewModel;
        }
    }
}
