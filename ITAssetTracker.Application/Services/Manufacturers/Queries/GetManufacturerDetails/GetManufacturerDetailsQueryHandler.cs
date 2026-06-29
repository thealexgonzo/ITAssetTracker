using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Manufacturers.Queries.GetManufacturerDetails
{
    public class GetManufacturerDetailsQueryHandler : IRequestHandler<GetManufacturerDetailsQuery, ManufacturerDetailsViewModel>
    {
        private readonly IManufacturerRepository manufacturerRepository;
        private readonly IMapper mapper;

        public GetManufacturerDetailsQueryHandler(IManufacturerRepository manufacturerRepository, IMapper mapper)
        {
            this.manufacturerRepository = manufacturerRepository;
            this.mapper = mapper;
        }

        public async Task<ManufacturerDetailsViewModel> Handle(GetManufacturerDetailsQuery request, CancellationToken cancellationToken)
        {
            var manufacturer = await manufacturerRepository.GetByIdAsync(request.Id)!;

            if (manufacturer is null)
            {
                throw new NotFoundException("Manufacturer", request.Id);
            }

            var manufacturerDetailViewModel = mapper.Map<ManufacturerDetailsViewModel>(manufacturer);

            return manufacturerDetailViewModel;
        }
    }
}
