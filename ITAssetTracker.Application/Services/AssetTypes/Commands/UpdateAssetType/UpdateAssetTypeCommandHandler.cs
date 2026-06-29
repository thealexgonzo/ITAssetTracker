using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;
using ValidationException = ITAssetTracker.Application.Exceptions.ValidationException;

namespace ITAssetTracker.Application.Services.AssetTypes.Commands.UpdateAssetType
{
    public class UpdateAssetTypeCommandHandler : IRequestHandler<UpdateAssetTypeCommand>
    {
        private readonly IAssetTypeRepository assetTypeRepository;
        private readonly IMapper mapper;

        public UpdateAssetTypeCommandHandler(IAssetTypeRepository assetTypeRepository, IMapper mapper)
        {
            this.assetTypeRepository = assetTypeRepository;
            this.mapper = mapper;
        }

        public async Task Handle(UpdateAssetTypeCommand request, CancellationToken cancellationToken)
        {
            var assetTypeToUpdate = await assetTypeRepository.GetByIdAsync(request.Id);

            if (assetTypeToUpdate is null)
            {
                throw new NotFoundException("Asset Type", request.Id);
            }

            var validator = new UpdateAssetTypeCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            mapper.Map(request, assetTypeToUpdate, typeof(UpdateAssetTypeCommand), typeof(AssetType));
            await assetTypeRepository.UpdateAsync(assetTypeToUpdate);
        }
    }
}
