using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsList;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Manufacturers.Queries.GetManufacturersList
{
    public class GetPrioritiesListQueryHandler : IRequestHandler<GetManufacturerListQuery, List<ManufacturerListViewModel>>
    {
        private readonly IManufacturerRepository manufacturerRepository;
        private readonly IMapper mapper;

        public GetPrioritiesListQueryHandler(IManufacturerRepository manufacturerRepository, IMapper mapper)
        {
            this.manufacturerRepository = manufacturerRepository;
            this.mapper = mapper;
        }

        public async Task<List<ManufacturerListViewModel>> Handle(GetManufacturerListQuery request, CancellationToken cancellationToken)
        {
            var allManufacturers = (await manufacturerRepository.ListAllAsync()).ToList();
            return mapper.Map<List<ManufacturerListViewModel>>(allManufacturers);
        }
    }
}
