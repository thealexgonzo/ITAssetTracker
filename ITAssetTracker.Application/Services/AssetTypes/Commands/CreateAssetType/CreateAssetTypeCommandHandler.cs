using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.AssetTypes.Commands.CreateAssetType;

public class CreateAssetTypeCommandHandler : IRequestHandler<CreateAssetTypeCommand, Guid>
{
    private readonly IAssetTypeRepository assetTypeRepository;
    private readonly IMapper mapper;

    public CreateAssetTypeCommandHandler(IAssetTypeRepository assetTypeRepository, IMapper mapper)
    {
        this.assetTypeRepository = assetTypeRepository;
        this.mapper = mapper;
    }
    public async Task<Guid> Handle(CreateAssetTypeCommand request, CancellationToken cancellationToken)
    {
        AssetType assetType = mapper.Map<AssetType>(request);

        CreateAssetTypeCommandValidator validator = new CreateAssetTypeCommandValidator();
        ValidationResult validationResult = await validator.ValidateAsync(request);
        
        if(validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        assetType = await assetTypeRepository.AddAsync(assetType);

        return assetType.Id;
    }
}
