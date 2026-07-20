using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Assets.Commands.UpdateAsset;

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

        if (assetToUpdate is null)
        {
            throw new NotFoundException("Asset", request.Id);
        }

        UpdateAssetCommandValidator validator = new UpdateAssetCommandValidator();
        ValidationResult validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        mapper.Map(request, assetToUpdate, typeof(UpdateAssetCommand), typeof(Asset));
        await assetRepository.UpdateAsync(assetToUpdate); // TODO: Need to add validation, the asset cannot be null if you want to update it
    }
}