using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Commands.DeleteSupportTicket
{
    public class DeleteSupportTicketCommandHandler : IRequestHandler<DeleteSupportTicketCommand>
    {
        private readonly ISupportTicketRepository supportTicketRepository;
        private readonly IMapper mapper;

        public DeleteSupportTicketCommandHandler(ISupportTicketRepository supportTicketRepository, IMapper mapper)
        {
            this.supportTicketRepository = supportTicketRepository;
            this.mapper = mapper;
        }

        public async Task Handle(DeleteSupportTicketCommand request, CancellationToken cancellationToken)
        {
            var supportTicketToDelete = await supportTicketRepository.GetByIdAsync(request.Id);

            if (supportTicketToDelete is null)
            {
                throw new NotFoundException("Support Ticket", request.Id);
            }

            await supportTicketRepository.DeleteAsync(supportTicketToDelete);
        }
    }
}
