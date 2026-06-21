using AutoMapper;
using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Assets.Commands.DeleteAsset
{
    public class DeleteAssetCommandHandler : IRequestHandler<DeleteAssetCommand>
    {
        private readonly IAsyncRepository<Asset> assetRepository;
        private readonly IMapper mapper;

        public DeleteAssetCommandHandler(IAsyncRepository<Asset> assetRepository, IMapper mapper)
        {
            this.assetRepository = assetRepository;
            this.mapper = mapper;
        }
        public async Task Handle(DeleteAssetCommand request, CancellationToken cancellationToken)
        {
            Asset assetToDelete = await assetRepository.GetByIdAsync(request.Id);
            await assetRepository.DeleteAsync(assetToDelete);
        }
    }
}
