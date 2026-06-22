using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.AssetProducts.Commands.UpdateAssetProduct;

public class UpdateAssetProductCommandHandler : IRequestHandler<UpdateAssetProductCommand>
{
    private readonly IMapper mapper;
    private readonly IAssetProductRepository assetProductRepository;

    public UpdateAssetProductCommandHandler(IMapper mapper, IAssetProductRepository assetProductRepository)
    {
        this.mapper = mapper;
        this.assetProductRepository = assetProductRepository;
    }
    public async Task Handle(UpdateAssetProductCommand request, CancellationToken cancellationToken)
    {
        AssetProduct? assetProductToUpdate = await assetProductRepository.GetByIdAsync(request.Id);

        UpdateAssetProductCommandValidator validator = new UpdateAssetProductCommandValidator();
        ValidationResult validationResult = await validator.ValidateAsync(request);

        if(validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        if (assetProductToUpdate is null)
        {
            throw new NotFoundException("Asset Product", request.Id);
        }

        mapper.Map(request, assetProductToUpdate, typeof(UpdateAssetProductCommand), typeof(AssetProduct));
        await assetProductRepository.UpdateAsync(assetProductToUpdate);
    }
}
