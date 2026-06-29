using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Commands.UpdateAsset;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Priorities.Commands.UpdatePriorities
{
    public class UpdateManufacturerCommandHandler : IRequestHandler<UpdatePrioritiesCommand>
    {
        private readonly IPriorityRepository priorityRepository;
        private readonly IMapper mapper;

        public UpdateManufacturerCommandHandler(IPriorityRepository priorityRepository, IMapper mapper)
        {
            this.priorityRepository = priorityRepository;
            this.mapper = mapper;
        }

        public async Task Handle(UpdatePrioritiesCommand request, CancellationToken cancellationToken)
        {
            var priorityToUpdate = await priorityRepository.GetByIdAsync(request.Id);

            if (priorityToUpdate is null)
            {
                throw new NotFoundException("Priority", request.Id);
            }

            var validator = new UpdatePrioritiesCommandValidator();
            ValidationResult validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            mapper.Map(request, priorityToUpdate, typeof(UpdatePrioritiesCommand), typeof(Priority));
            await priorityRepository.UpdateAsync(priorityToUpdate); // TODO: Need to add validation, the asset cannot be null if you want to update it
        }
    }
}
