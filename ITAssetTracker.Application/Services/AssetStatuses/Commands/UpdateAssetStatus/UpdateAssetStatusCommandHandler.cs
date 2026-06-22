using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Commands.UpdateAsset;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.AssetStatuses.Commands.UpdateAssetStatus;

public class UpdateAssetStatusCommandHandler : IRequestHandler<UpdateAssetStatusCommand>
{
    private readonly IMapper mapper;
    private readonly IAssetStatusRepository assetStatusRepository;

    public UpdateAssetStatusCommandHandler(IMapper mapper, IAssetStatusRepository assetStatusRepository)
    {
        this.mapper = mapper;
        this.assetStatusRepository = assetStatusRepository;
    }

    public async Task Handle(UpdateAssetStatusCommand request, CancellationToken cancellationToken)
    {
        AssetStatus? assetToUpdate = await assetStatusRepository.GetByIdAsync(request.Id);
        
        if (assetToUpdate is null)
        {
            throw new NotFoundException("Asset Status", request.Id);
        }

        UpdateAssetStatusCommandValidator validator = new UpdateAssetStatusCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }


        mapper.Map(request, assetToUpdate, typeof(UpdateAssetCommand), typeof(Asset));
        await assetStatusRepository.UpdateAsync(assetToUpdate);
    }
}
