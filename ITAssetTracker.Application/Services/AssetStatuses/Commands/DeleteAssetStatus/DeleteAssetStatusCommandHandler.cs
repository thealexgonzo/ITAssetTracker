using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.AssetStatuses.Commands.DeleteAssetStatus;

public class DeleteAssetStatusCommandHandler : IRequestHandler<DeleteAssetStatusCommand>
{
    private readonly IMapper mapper;
    private readonly IAssetStatusRepository assetStatusRepository;

    public DeleteAssetStatusCommandHandler(IMapper mapper, IAssetStatusRepository assetStatusRepository)
    {
        this.mapper = mapper;
        this.assetStatusRepository = assetStatusRepository;
    }

    public async Task Handle(DeleteAssetStatusCommand request, CancellationToken cancellationToken)
    {
        var assetStatusToDelete = await assetStatusRepository.GetByIdAsync(request.Id);

        if (assetStatusToDelete is null)
        {
            throw new NotFoundException("Asset Status", request.Id);
        }

        await assetStatusRepository.DeleteAsync(assetStatusToDelete);
    }
}
