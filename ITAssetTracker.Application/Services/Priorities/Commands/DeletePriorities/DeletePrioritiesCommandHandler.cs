using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Priorities.Commands.DeletePriorities;

public class DeletePrioritiesCommandHandler : IRequestHandler<DeletePrioritiesCommand>
{
    private readonly IPriorityRepository priorityRepository;
    private readonly IMapper mapper;

    public DeletePrioritiesCommandHandler(IPriorityRepository priorityRepository, IMapper mapper)
    {
        this.priorityRepository = priorityRepository;
        this.mapper = mapper;
    }

    public async Task Handle(DeletePrioritiesCommand request, CancellationToken cancellationToken)
    {
        Priority? priorityToDelete = await priorityRepository.GetByIdAsync(request.Id);

        if (priorityToDelete is null)
        {
            throw new NotFoundException("Priority", request.Id);
        }

        await priorityRepository.DeleteAsync(priorityToDelete);
    }
}
