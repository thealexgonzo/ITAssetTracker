using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Features.Assets.Commands.CreateAsset
{
    public class CreateAssetCommandHandler : IRequestHandler<CreateAssetCommand, Guid>
    {
        private readonly IMapper mapper;
        private readonly IAssetRepository assetRepository;

        public CreateAssetCommandHandler(IMapper mapper, IAssetRepository assetRepository)
        {
            this.mapper = mapper;
            this.assetRepository = assetRepository;
        }
        public async Task<Guid> Handle(CreateAssetCommand request, CancellationToken cancellationToken)
        {
            Asset asset = mapper.Map<Asset>(request);
            asset = await assetRepository.Add(asset);
            return asset.AssetId;
        }
    }
}
