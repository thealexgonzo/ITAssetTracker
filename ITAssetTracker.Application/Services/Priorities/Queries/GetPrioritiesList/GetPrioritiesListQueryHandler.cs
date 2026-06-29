using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsList;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Priorities.Queries.GetPrioritiesList
{
    public class GetPrioritiesListQueryHandler : IRequestHandler<GetPrioritiesListQuery, List<PrioritiesListViewModel>>
    {
        private readonly IPriorityRepository priorityRepository;
        private readonly IMapper mapper;

        public GetPrioritiesListQueryHandler(IPriorityRepository priorityRepository, IMapper mapper)
        {
            this.priorityRepository = priorityRepository;
            this.mapper = mapper;
        }

        public async Task<List<PrioritiesListViewModel>> Handle(GetPrioritiesListQuery request, CancellationToken cancellationToken)
        {
            var allPriorities = (await priorityRepository.ListAllAsync()).ToList();
            return mapper.Map<List<PrioritiesListViewModel>>(allPriorities);
        }
    }
}
