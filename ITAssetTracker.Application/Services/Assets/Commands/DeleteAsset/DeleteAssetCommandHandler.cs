using AutoMapper;
using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Assets.Commands.DeleteAsset;

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
        Asset? assetToDelete = await assetRepository.GetByIdAsync(request.Id);
        
        if (assetToDelete is null)
        {
            throw new NotFoundException("Asset", request.Id);
        }
        
        await assetRepository.DeleteAsync(assetToDelete);
    }
}
