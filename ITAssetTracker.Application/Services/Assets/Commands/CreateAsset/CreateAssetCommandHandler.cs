using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Assets.Commands.CreateAsset
{
    public class CreateAssetCommandHandler : IRequestHandler<CreateAssetCommand, Guid>
    {
        private readonly IMapper mapper;
        private readonly IAssetRepository assetRepository;

        public CreateAssetCommandHandler(IMapper mapper, IAssetRepository assetRepository)
        {
            this.mapper = mapper;
            this.assetRepository = assetRepository;
        }
        public async Task<Guid> Handle(CreateAssetCommand request, CancellationToken cancellationToken)
        {
            Asset asset = mapper.Map<Asset>(request);

            CreateAssetCommandValidator validator = new CreateAssetCommandValidator();
            ValidationResult validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            asset = await assetRepository.AddAsync(asset);
            return asset.AssetId;
        }
    }
}
