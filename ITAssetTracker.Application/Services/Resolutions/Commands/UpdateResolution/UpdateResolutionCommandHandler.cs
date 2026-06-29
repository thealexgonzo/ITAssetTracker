using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Commands.UpdateAsset;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Resolutions.Commands.UpdateResolution
{
    public class UpdateResolutionCommandHandler : IRequestHandler<UpdateResolutionCommand>
    {
        private readonly IResolutionRepository resolutionRepository;
        private readonly IMapper mapper;

        public UpdateResolutionCommandHandler(IResolutionRepository resolutionRepository, IMapper mapper)
        {
            this.resolutionRepository = resolutionRepository;
            this.mapper = mapper;
        }

        public async Task Handle(UpdateResolutionCommand request, CancellationToken cancellationToken)
        {
            var resolutionToUpdate = await resolutionRepository.GetByIdAsync(request.Id);

            if (resolutionToUpdate is null)
            {
                throw new NotFoundException("Resolution", request.Id);
            }

            var validator = new UpdateResolutionCommandValidator();
            ValidationResult validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            mapper.Map(request, resolutionToUpdate, typeof(UpdateResolutionCommand), typeof(Resolution));
            await resolutionRepository.UpdateAsync(resolutionToUpdate); // TODO: Need to add validation, the asset cannot be null if you want to update it
        }
    }
}
