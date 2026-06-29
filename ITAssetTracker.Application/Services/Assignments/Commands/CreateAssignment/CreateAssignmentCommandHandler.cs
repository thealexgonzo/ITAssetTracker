using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Assignments.Commands.CreateAssignment
{
    public class CreateAssignmentCommandHandler : IRequestHandler<CreateAssignmentCommand, Guid>
    {
        private readonly IAssetAssignmentRepository assetAssignmentRepository;
        private readonly IMapper mapper;

        public CreateAssignmentCommandHandler(IAssetAssignmentRepository assetAssignmentRepository, IMapper mapper)
        {
            this.assetAssignmentRepository = assetAssignmentRepository;
            this.mapper = mapper;
        }
        public async Task<Guid> Handle(CreateAssignmentCommand request, CancellationToken cancellationToken)
        {
            var assetAssignment = mapper.Map<AssetAssignment>(request);

            var validator = new CreateAssignmentCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            assetAssignment = await assetAssignmentRepository.AddAsync(assetAssignment);

            return assetAssignment.Id;
        }
    }
}
