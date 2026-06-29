using AutoMapper;
using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetStatuses.Queries.GetAssetStatusDetails
{
    public class GetAssetStatusDetailsQueryHandler : IRequestHandler<GetAssetStatusDetailsQuery, AssetStatusDetailsViewModel>
    {
        private readonly IAssetStatusRepository assetStatusRepository;
        private readonly IMapper mapper;

        public GetAssetStatusDetailsQueryHandler(IAssetStatusRepository assetStatusRepository, IMapper mapper)
        {
            this.assetStatusRepository = assetStatusRepository;
            this.mapper = mapper;
        }
        public async Task<AssetStatusDetailsViewModel> Handle(GetAssetStatusDetailsQuery request, CancellationToken cancellationToken)
        {
            AssetStatus? assetStatus = await assetStatusRepository.GetByIdAsync(request.Id);

            if(assetStatus is null)
            {
                throw new NotFoundException("Asset Status", request.Id);
            }

            AssetStatusDetailsViewModel assetStatusDetailsViewModel = mapper.Map<AssetStatusDetailsViewModel>(assetStatus);

            return assetStatusDetailsViewModel;
        }
    }
}
