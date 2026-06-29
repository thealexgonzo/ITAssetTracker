using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsList;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Queries.GetSupportTicketsList
{
    public class GetSupportTicketListQueryHandler : IRequestHandler<GetSupportTicketListQuery, List<SupportTicketListViewModel>>
    {
        private readonly ISupportTicketRepository supportTicketRepository;
        private readonly IMapper mapper;

        public GetSupportTicketListQueryHandler(ISupportTicketRepository supportTicketRepository, IMapper mapper)
        {
            this.supportTicketRepository = supportTicketRepository;
            this.mapper = mapper;
        }
        public async Task<List<SupportTicketListViewModel>> Handle(GetSupportTicketListQuery request, CancellationToken cancellationToken)
        {
            var allSupportTickets = (await supportTicketRepository.ListAllAsync()).ToList();
            return mapper.Map<List<SupportTicketListViewModel>>(allSupportTickets);
        }
    }
}
