using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Assignments.Commands.UpdateAssignment;

public class UpdateAssignmentCommandHandler : IRequestHandler<UpdateAssignmentCommand>
{
    private readonly IAssetAssignmentRepository assetAssignmentRepository;
    private readonly IMapper mapper;

    public UpdateAssignmentCommandHandler(IAssetAssignmentRepository assetAssignmentRepository, IMapper mapper)
    {
        this.assetAssignmentRepository = assetAssignmentRepository;
        this.mapper = mapper;
    }

    public async Task Handle(UpdateAssignmentCommand request, CancellationToken cancellationToken)
    {
        var assetAssignmentToUpdate = await assetAssignmentRepository.GetByIdAsync(request.Id);

        if (assetAssignmentToUpdate is null)
        {
            throw new NotFoundException("Asset Assignment", request.Id);
        }

        var validator = new UpdateAssignmentCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        if(validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        mapper.Map(request, assetAssignmentToUpdate, typeof(UpdateAssignmentCommand), typeof(AssetAssignment));
        await assetAssignmentRepository.UpdateAsync(assetAssignmentToUpdate); // TODO: Need to add validation, the asset cannot be null if you want to update it
    }
}
