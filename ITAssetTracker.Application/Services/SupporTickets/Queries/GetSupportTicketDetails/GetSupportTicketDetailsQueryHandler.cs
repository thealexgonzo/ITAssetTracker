using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.SupporTickets.Queries.GetSupportTicketDetails
{
    public class GetSupportTicketDetailsQueryHandler : IRequestHandler<GetSupportTicketDetailsQuery, SupportTicketDetailsViewModel>
    {
        private readonly ISupportTicketRepository supportTicketRepository;
        private readonly IMapper mapper;
        private readonly IAssetRepository assetRepository;
        private readonly IEmployeeRepository employeeRepository;
        private readonly ITicketStatusRepository ticketStatusRepository;
        private readonly IPriorityRepository priorityRepository;
        private readonly IResolutionRepository resolutionRespository;

        public GetSupportTicketDetailsQueryHandler(ISupportTicketRepository supportTicketRepository, IMapper mapper,
            IAssetRepository assetRepository, IEmployeeRepository employeeRepository, ITicketStatusRepository ticketStatusRepository,
            IPriorityRepository priorityRepository, IResolutionRepository resolutionRespository)
        {
            this.supportTicketRepository = supportTicketRepository;
            this.mapper = mapper;
            this.assetRepository = assetRepository;
            this.employeeRepository = employeeRepository;
            this.ticketStatusRepository = ticketStatusRepository;
            this.priorityRepository = priorityRepository;
            this.resolutionRespository = resolutionRespository;
        }
        public async Task<SupportTicketDetailsViewModel> Handle(GetSupportTicketDetailsQuery request, CancellationToken cancellationToken)
        {
            SupportTicket? supportTicket = await supportTicketRepository.GetByIdAsync(request.Id)!;

            if (supportTicket is null)
            {
                throw new NotFoundException("Asset", request.Id);
            }

            SupportTicketDetailsViewModel supportTicketDetailViewModel = mapper.Map<SupportTicketDetailsViewModel>(supportTicket);

            var asset = await assetRepository.GetByIdAsync(supportTicket.AssetId)!;
            var employee = await employeeRepository.GetByIdAsync(supportTicket.EmployeeId)!;
            var ticketStatus = await ticketStatusRepository.GetByIdAsync(supportTicket.TicketStatusId)!;
            var priority = await priorityRepository.GetByIdAsync(supportTicket.PriorityId)!;
            var resolution = await resolutionRespository.GetByIdAsync(supportTicket.ResolutionId)!;

            supportTicketDetailViewModel.Asset = mapper.Map<Asset>(asset);
            supportTicketDetailViewModel.Employee = mapper.Map<Employee>(employee);
            supportTicketDetailViewModel.TicketStatus = mapper.Map<TicketStatus>(ticketStatus);
            supportTicketDetailViewModel.Priority = mapper.Map<Priority>(priority);
            supportTicketDetailViewModel.Resolution = mapper.Map<Resolution>(resolution);

            return supportTicketDetailViewModel;
        }
    }
}
