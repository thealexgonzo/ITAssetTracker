using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Commands.UpdateAsset;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Commands.UpdateSupportTicket
{
    public class UpdateSupportTicketCommandHandler : IRequestHandler<UpdateSupportTicketCommand>
    {
        private readonly ISupportTicketRepository supportTicketRepository;
        private readonly IMapper mapper;

        public UpdateSupportTicketCommandHandler(ISupportTicketRepository supportTicketRepository, IMapper mapper)
        {
            this.supportTicketRepository = supportTicketRepository;
            this.mapper = mapper;
        }

        public async Task Handle(UpdateSupportTicketCommand request, CancellationToken cancellationToken)
        {
            var supportTicketToUpdate = await supportTicketRepository.GetByIdAsync(request.Id);

            if (supportTicketToUpdate is null)
            {
                throw new NotFoundException("Asset", request.Id);
            }

            var validator = new UpdateSupportTicketCommandValidator();
            ValidationResult validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            mapper.Map(request, supportTicketToUpdate, typeof(UpdateAssetCommand), typeof(Asset));
            await supportTicketRepository.UpdateAsync(supportTicketToUpdate); // TODO: Need to add validation, the asset cannot be null if you want to update it
        }
    }
}
