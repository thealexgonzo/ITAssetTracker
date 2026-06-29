using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Resolutions.Queries.GetResolutionDetails
{
    public class GetResolutionDetailsQueryHandler : IRequestHandler<GetResolutionDetailsQuery, ResolutionDetailsViewModel>
    {
        private readonly IResolutionRepository resolutionRepository;
        private readonly IMapper mapper;

        public GetResolutionDetailsQueryHandler(IResolutionRepository resolutionRepository, IMapper mapper)
        {
            this.resolutionRepository = resolutionRepository;
            this.mapper = mapper;
        }

        public async Task<ResolutionDetailsViewModel> Handle(GetResolutionDetailsQuery request, CancellationToken cancellationToken)
        {
            var resolutoin = await resolutionRepository.GetByIdAsync(request.Id)!;

            if (resolutoin is null)
            {
                throw new NotFoundException("Resolution", request.Id);
            }

            var assetDetailViewModel = mapper.Map<ResolutionDetailsViewModel>(resolutoin);

            return assetDetailViewModel;
        }
    }
}
