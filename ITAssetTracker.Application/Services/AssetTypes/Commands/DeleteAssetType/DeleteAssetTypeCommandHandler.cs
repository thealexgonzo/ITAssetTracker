using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetTypes.Commands.DeleteAssetType
{
    public class DeleteAssetTypeCommandHandler : IRequestHandler<DeleteAssetTypeCommand>
    {
        private readonly IAssetTypeRepository assetTypeRepository;
        private readonly IMapper mapper;

        public DeleteAssetTypeCommandHandler(IAssetTypeRepository assetTypeRepository, IMapper mapper)
        {
            this.assetTypeRepository = assetTypeRepository;
            this.mapper = mapper;
        }

        public async Task Handle(DeleteAssetTypeCommand request, CancellationToken cancellationToken)
        {
            var assetTypeToDelete = await assetTypeRepository.GetByIdAsync(request.Id);

            if(assetTypeToDelete is null)
            {
                throw new NotFoundException("Asset Type", request.Id);
            }

            await assetTypeRepository.DeleteAsync(assetTypeToDelete);
        }
    }
}
