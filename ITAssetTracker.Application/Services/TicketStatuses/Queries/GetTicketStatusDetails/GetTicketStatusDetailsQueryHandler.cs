using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.TicketStatuses.Queries.GetTicketStatusDetails
{
    public class GetTicketStatusDetailsQueryHandler : IRequestHandler<GetTicketStatusDetailsQuery, TicketStatusDetailsViewModel>
    {
        private readonly ITicketStatusRepository ticketStatusRepository;
        private readonly IMapper mapper;

        public GetTicketStatusDetailsQueryHandler(ITicketStatusRepository ticketStatusRepository, IMapper mapper)
        {
            this.ticketStatusRepository = ticketStatusRepository;
            this.mapper = mapper;
        }

        public async Task<TicketStatusDetailsViewModel> Handle(GetTicketStatusDetailsQuery request, CancellationToken cancellationToken)
        {
            var ticketStatus = await ticketStatusRepository.GetByIdAsync(request.Id)!;

            if (ticketStatus is null)
            {
                throw new NotFoundException("Ticket Status", request.Id);
            }

            var ticketStatusDetailViewModel = mapper.Map<TicketStatusDetailsViewModel>(ticketStatus);

            return ticketStatusDetailViewModel;
        }
    }
}
