using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.AssetStatuses.Commands.CreateAssetStatus;

public class CreateAssetStatusCommandHandler : IRequestHandler<CreateAssetStatusCommand, Guid>
{
    private readonly IMapper mapper;
    private readonly IAssetStatusRepository assetStatusRepository;

    public CreateAssetStatusCommandHandler(IMapper mapper, IAssetStatusRepository assetStatusRepository)
    {
        this.mapper = mapper;
        this.assetStatusRepository = assetStatusRepository;
    }
    public async Task<Guid> Handle(CreateAssetStatusCommand request, CancellationToken cancellationToken)
    {
        AssetStatus assetStatus = mapper.Map<AssetStatus>(request);

        CreateAssetStatusCommandValidator validator = new CreateAssetStatusCommandValidator();
        ValidationResult validationResult = await validator.ValidateAsync(request);

        if(validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        assetStatus = await assetStatusRepository.AddAsync(assetStatus);

        return assetStatus.Id;
    }
}
