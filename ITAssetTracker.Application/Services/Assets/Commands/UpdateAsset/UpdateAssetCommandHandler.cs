using AutoMapper;
using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Assets.Commands.UpdateAsset
{
    public class UpdateAssetCommandHandler : IRequestHandler<UpdateAssetCommand>
    {
        private readonly IAsyncRepository<Asset> assetRepository;
        private readonly IMapper mapper;

        public UpdateAssetCommandHandler(IAsyncRepository<Asset> assetRepository, IMapper mapper)
        {
            this.assetRepository = assetRepository;
            this.mapper = mapper;
        }

        public async Task Handle(UpdateAssetCommand request, CancellationToken cancellationToken)
        {
            Asset? assetToUpdate = await assetRepository.GetByIdAsync(request.Id);
            mapper.Map(request, assetToUpdate, typeof(UpdateAssetCommand), typeof(Asset));
            await assetRepository.UpdateAsync(assetToUpdate); // TODO: Need to add validation, the asset cannot be null if you want to update it
        }
    }
}
