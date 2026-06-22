using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;
using FluentValidation.Results;

namespace ITAssetTracker.Application.Services.AssetProducts.Commands.DeleteAssetProduct;

public class DeleteAssetProductCommandHandler : IRequestHandler<DeleteAssetProductCommand>
{
    private readonly IMapper mapper;
    private readonly IAssetProductRepository assetProductRepository;

    public DeleteAssetProductCommandHandler(IMapper mapper, IAssetProductRepository assetProductRepository)
    {
        this.mapper = mapper;
        this.assetProductRepository = assetProductRepository;
    }
    public async Task Handle(DeleteAssetProductCommand request, CancellationToken cancellationToken)
    {
        AssetProduct? assetProductToDelete = await assetProductRepository.GetByIdAsync(request.Id);
        DeleteAssetProductCommandValidator validator = new DeleteAssetProductCommandValidator();
        ValidationResult validationResult = await validator.ValidateAsync(request);

        if(validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        if(assetProductToDelete is null)
        {
            throw new NotFoundException("Asset Product", request.Id);
        }

        await assetProductRepository.DeleteAsync(assetProductToDelete!);
    }
}
