using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using MediatR;

namespace ITAssetTracker.Application.Services.Priorities.Queries.GetPrioritiesDetails
{
    public class GetPrioritiesDetailsQueryHandler : IRequestHandler<GetPrioritiesDetailsQuery, PrioritiesDetailsViewModel>
    {
        private readonly IPriorityRepository priorityRepository;
        private readonly IMapper mapper;

        public GetPrioritiesDetailsQueryHandler(IPriorityRepository priorityRepository, IMapper mapper)
        {
            this.priorityRepository = priorityRepository;
            this.mapper = mapper;
        }

        public async Task<PrioritiesDetailsViewModel> Handle(GetPrioritiesDetailsQuery request, CancellationToken cancellationToken)
        {
            var priority = await priorityRepository.GetByIdAsync(request.Id)!;

            if (priority is null)
            {
                throw new NotFoundException("Priority", request.Id);
            }

            PrioritiesDetailsViewModel priorityDetailViewModel = mapper.Map<PrioritiesDetailsViewModel>(priority);

            return priorityDetailViewModel;
        }
    }
}
