using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Priorities.Commands.CreatePriorities;

public class CreatePrioritiesCommandHandler : IRequestHandler<CreatePrioritiesCommand, Guid>
{
    private readonly IPriorityRepository priorityRepository;
    private readonly IMapper mapper;

    public CreatePrioritiesCommandHandler(IPriorityRepository priorityRepository, IMapper mapper)
    {
        this.priorityRepository = priorityRepository;
        this.mapper = mapper;
    }

    public async Task<Guid> Handle(CreatePrioritiesCommand request, CancellationToken cancellationToken)
    {
        // Map
        Priority priority = mapper.Map<Priority>(request);

        // Validate
        CreatePrioritiesCommandValidator validator = new CreatePrioritiesCommandValidator();
        ValidationResult validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        // Act
        priority = await priorityRepository.AddAsync(priority);

        // Return 
        return priority.Id;
    }
}
