using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.AssetProducts.Commands.CreateAssetProduct;

public class CreateAssetProductCommandHandler : IRequestHandler<CreateAssetProductCommand, Guid>
{
    private readonly IMapper mapper;
    private readonly IAssetProductRepository assetProductRepository;

    public CreateAssetProductCommandHandler(IMapper mapper, IAssetProductRepository assetProductRepository)
    {
        this.mapper = mapper;
        this.assetProductRepository = assetProductRepository;
    }
    public async Task<Guid> Handle(CreateAssetProductCommand request, CancellationToken cancellationToken)
    {
        AssetProduct assetProduct = mapper.Map<AssetProduct>(request);

        CreateAssetProductCommandValidator validator = new CreateAssetProductCommandValidator();
        ValidationResult validationResult = await validator.ValidateAsync(request);

        if(validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        assetProduct = await assetProductRepository.AddAsync(assetProduct);
        return assetProduct.Id;
    }
}
