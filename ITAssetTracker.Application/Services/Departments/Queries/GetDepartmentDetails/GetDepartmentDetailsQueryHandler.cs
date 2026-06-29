using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using MediatR;

namespace ITAssetTracker.Application.Services.Departments.Queries.GetDepartmentDetails
{
    public class GetDepartmentDetailsQueryHandler : IRequestHandler<GetDepartmentDetailsQuery, DepartmentDetailsViewModel>
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;

        public GetDepartmentDetailsQueryHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            this.departmentRepository = departmentRepository;
            this.mapper = mapper;
        }

        public async Task<DepartmentDetailsViewModel> Handle(GetDepartmentDetailsQuery request, CancellationToken cancellationToken)
        {
            var department = await departmentRepository.GetByIdAsync(request.Id)!;

            if (department is null)
            {
                throw new NotFoundException("Asset", request.Id);
            }

            var departmentDetailViewModel = mapper.Map<DepartmentDetailsViewModel>(department);

            return departmentDetailViewModel;
        }
    }
}
