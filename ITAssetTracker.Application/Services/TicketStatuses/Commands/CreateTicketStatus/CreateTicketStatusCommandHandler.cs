using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.TicketStatuses.Commands.CreateTicketStatus
{
    public class CreateTicketStatusCommandHandler : IRequestHandler<CreateTicketStatusCommand, int>
    {
        private readonly ITicketStatusRepository ticketStatusRepository;
        private readonly IMapper mapper;

        public CreateTicketStatusCommandHandler(ITicketStatusRepository ticketStatusRepository, IMapper mapper)
        {
            this.ticketStatusRepository = ticketStatusRepository;
            this.mapper = mapper;
        }

        public async Task<int> Handle(CreateTicketStatusCommand request, CancellationToken cancellationToken)
        {
            // Map
            var ticketStatus = mapper.Map<TicketStatus>(request);

            // Validate
            var validator = new CreateTicketStatusCommandValidator();
            ValidationResult validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            // Act
            ticketStatus = await ticketStatusRepository.AddAsync(ticketStatus);

            // Return 
            return ticketStatus.Id;
        }
    }
}
