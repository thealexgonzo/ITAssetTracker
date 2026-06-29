using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.TicketStatuses.Commands.DeleteTicketStatus
{
    public class DeleteTicketStatusCommandHandler : IRequestHandler<DeleteTicketStatusCommand>
    {
        private readonly ITicketStatusRepository ticketStatusRepository;
        private readonly IMapper mapper;

        public DeleteTicketStatusCommandHandler(ITicketStatusRepository ticketStatusRepository, IMapper mapper)
        {
            this.ticketStatusRepository = ticketStatusRepository;
            this.mapper = mapper;
        }

        public async Task Handle(DeleteTicketStatusCommand request, CancellationToken cancellationToken)
        {
            var ticketStatusToDelete = await ticketStatusRepository.GetByIdAsync(request.Id);

            if (ticketStatusToDelete is null)
            {
                throw new NotFoundException("Ticket Status", request.Id);
            }

            await ticketStatusRepository.DeleteAsync(ticketStatusToDelete);
        }
    }
}
