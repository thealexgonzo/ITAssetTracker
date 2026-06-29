using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Resolutions.Commands.DeleteResolution
{
    public class DeleteResolutionCommandHandler : IRequestHandler<DeleteResolutionCommand>
    {
        private readonly IResolutionRepository resolutionRepository;
        private readonly IMapper mapper;

        public DeleteResolutionCommandHandler(IResolutionRepository resolutionRepository, IMapper mapper)
        {
            this.resolutionRepository = resolutionRepository;
            this.mapper = mapper;
        }

        public async Task Handle(DeleteResolutionCommand request, CancellationToken cancellationToken)
        {
            var resolutionToDelete = await resolutionRepository.GetByIdAsync(request.Id);

            if (resolutionToDelete is null)
            {
                throw new NotFoundException("Resolution", request.Id);
            }

            await resolutionRepository.DeleteAsync(resolutionToDelete);
        }
    }
}
