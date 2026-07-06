using AutoMapper;
using ITAssetTracker.Application.Contracts.Infrastructure;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Models.Mail;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Assignments.Commands.CreateAssignment
{
    public class CreateAssignmentCommandHandler : IRequestHandler<CreateAssignmentCommand, int>
    {
        private readonly IAssetAssignmentRepository assetAssignmentRepository;
        private readonly IMapper mapper;
        private readonly IEmailService emailService;

        public CreateAssignmentCommandHandler(IAssetAssignmentRepository assetAssignmentRepository, IMapper mapper, IEmailService emailService)
        {
            this.assetAssignmentRepository = assetAssignmentRepository;
            this.mapper = mapper;
            this.emailService = emailService;
        }
        public async Task<int> Handle(CreateAssignmentCommand request, CancellationToken cancellationToken)
        {
            var assetAssignment = mapper.Map<AssetAssignment>(request);

            var validator = new CreateAssignmentCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            assetAssignment = await assetAssignmentRepository.AddAsync(assetAssignment);

            //NOTE: Send email notification example
            var email = new Email()
            {
                To = "example@example.com",
                Body = "A new asset was assigned.",
                Subject = "A new asset was assigned."
            };

            try
            {
                await emailService.SendEmail(email);
            }
            catch (Exception)
            {
                // NOTE: this shouldn't stop the API from completing the assigned. Rather it should be logged elsewhere.
            }

            return assetAssignment.Id;
        }
    }
}
