using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsList;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.TicketStatuses.Queries.GetTicketStatusList
{
    public class GetTicketStatusListQueryHandler : IRequestHandler<GetTicketStatusListQuery, List<TicketStatusListViewModel>>
    {
        private readonly ITicketStatusRepository ticketStatusRepository;
        private readonly IMapper mapper;

        public GetTicketStatusListQueryHandler(ITicketStatusRepository ticketStatusRepository, IMapper mapper)
        {
            this.ticketStatusRepository = ticketStatusRepository;
            this.mapper = mapper;
        }

        public async Task<List<TicketStatusListViewModel>> Handle(GetTicketStatusListQuery request, CancellationToken cancellationToken)
        {
            var allTicketStatuses = (await ticketStatusRepository.ListAllAsync()).ToList();
            return mapper.Map<List<TicketStatusListViewModel>>(allTicketStatuses);
        }
    }
}
