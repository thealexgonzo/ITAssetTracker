using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsList;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Resolutions.Queries.GetResolutionsList
{
    public class GetResolutionListQueryHandler : IRequestHandler<GetResolutionListQuery, List<ResolutionListViewModel>>
    {
        private readonly IResolutionRepository resolutionRepository;
        private readonly IMapper mapper;

        public GetResolutionListQueryHandler(IResolutionRepository resolutionRepository, IMapper mapper)
        {
            this.resolutionRepository = resolutionRepository;
            this.mapper = mapper;
        }

        public async Task<List<ResolutionListViewModel>> Handle(GetResolutionListQuery request, CancellationToken cancellationToken)
        {
            var allResolutions = (await resolutionRepository.ListAllAsync()).ToList();
            return mapper.Map<List<ResolutionListViewModel>>(allResolutions);
        }
    }
}
