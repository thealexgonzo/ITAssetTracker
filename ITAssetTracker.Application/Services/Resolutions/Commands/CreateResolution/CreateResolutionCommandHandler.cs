using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Commands.CreateAsset;
using MediatR;

namespace ITAssetTracker.Application.Services.Resolutions.Commands.CreateResolution
{
    public class CreateResolutionCommandHandler : IRequestHandler<CreateResolutionCommand, Guid>
    {
        private readonly IResolutionRepository resolutionRepository;
        private readonly IMapper mapper;

        public CreateResolutionCommandHandler(IResolutionRepository resolutionRepository, IMapper mapper)
        {
            this.resolutionRepository = resolutionRepository;
            this.mapper = mapper;
        }

        public async Task<Guid> Handle(CreateResolutionCommand request, CancellationToken cancellationToken)
        {
            // Map
            var resolution = mapper.Map<Domain.Entities.Resolution>(request);

            // Validate
            var validator = new CreateResolutionCommandValidator();
            ValidationResult validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            // Act
            resolution = await resolutionRepository.AddAsync(resolution);

            // Return 
            return resolution.Id;
        }
    }
}
