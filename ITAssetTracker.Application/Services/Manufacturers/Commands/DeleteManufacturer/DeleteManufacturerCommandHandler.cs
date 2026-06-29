using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Categories.Commands.DeleteCategory;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Manufacturers.Commands.DeleteManufacturer
{
    public class DeleteManufacturerCommandHandler: IRequestHandler<DeleteCategoryCommand>
    {
        private readonly IManufacturerRepository manufacturerRepository;
        private readonly IMapper mapper;

        public DeleteManufacturerCommandHandler(IManufacturerRepository manufacturerRepository, IMapper mapper)
        {
            this.manufacturerRepository = manufacturerRepository;
            this.mapper = mapper;
        }

        public async Task Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var manufacturerToDelete = await manufacturerRepository.GetByIdAsync(request.Id);

            if (manufacturerToDelete is null)
            {
                throw new NotFoundException("Manufacturer", request.Id);
            }

            await manufacturerRepository.DeleteAsync(manufacturerToDelete);
        }
    }
}
