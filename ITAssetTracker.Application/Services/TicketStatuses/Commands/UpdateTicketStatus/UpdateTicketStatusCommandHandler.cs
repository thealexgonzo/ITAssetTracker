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

namespace ITAssetTracker.Application.Services.TicketStatuses.Commands.UpdateTicketStatus
{
    public class UpdateTicketStatusCommandHandler : IRequestHandler<UpdateTicketStatusCommand>
    {
        private readonly ITicketStatusRepository ticketStatusRepository;
        private readonly IMapper mapper;

        public UpdateTicketStatusCommandHandler(ITicketStatusRepository ticketStatusRepository, IMapper mapper)
        {
            this.ticketStatusRepository = ticketStatusRepository;
            this.mapper = mapper;
        }

        public async Task Handle(UpdateTicketStatusCommand request, CancellationToken cancellationToken)
        {
            var ticketStatusToUpdate = await ticketStatusRepository.GetByIdAsync(request.Id);

            if (ticketStatusToUpdate is null)
            {
                throw new NotFoundException("Asset", request.Id);
            }

            var validator = new UpdateTicketStatusCommandValidator();
            ValidationResult validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            mapper.Map(request, ticketStatusToUpdate, typeof(UpdateAssetCommand), typeof(Asset));
            await ticketStatusRepository.UpdateAsync(ticketStatusToUpdate); // TODO: Need to add validation, the asset cannot be null if you want to update it
        }
    }
}
