using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Commands.CreateAsset;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Commands.CreateSupportTicket
{
    public class CreateSupportTicketCommandHandler : IRequestHandler<CreateSupportTicketCommand, int>
    {
        private readonly ISupportTicketRepository supportTicketRepository;
        private readonly IMapper mapper;

        public CreateSupportTicketCommandHandler(ISupportTicketRepository supportTicketRepository, IMapper mapper)
        {
            this.supportTicketRepository = supportTicketRepository;
            this.mapper = mapper;
        }

        public async Task<int> Handle(CreateSupportTicketCommand request, CancellationToken cancellationToken)
        {
            // Map
            var supportTicket = mapper.Map<SupportTicket>(request);

            // Validate
            var validator = new CreateSupportTicketCommandValidator();
            ValidationResult validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            // Act
            supportTicket = await supportTicketRepository.AddAsync(supportTicket);

            // Return 
            return supportTicket.Id;
        }
    }
}
