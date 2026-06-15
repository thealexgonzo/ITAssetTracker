using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Features.Assets.Commands.UpdateAsset
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
            Asset assetToUpdate = await assetRepository.GetById(request.Id);
            mapper.Map(request, assetToUpdate, typeof(UpdateAssetCommand), typeof(Asset));
            await assetRepository.Update(assetToUpdate);
        }
    }
}
