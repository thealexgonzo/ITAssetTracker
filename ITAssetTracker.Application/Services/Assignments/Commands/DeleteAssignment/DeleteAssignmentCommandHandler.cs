using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ITAssetTracker.Application.Services.Assignments.Commands.DeleteAssignment
{
    public class DeleteAssignmentCommandHandler : IRequestHandler<DeleteAssignmentCommand>
    {
        private readonly IAssetAssignmentRepository assetAssignmentRepository;
        private readonly IMapper mapper;

        public DeleteAssignmentCommandHandler(IAssetAssignmentRepository assetAssignmentRepository, IMapper mapper)
        {
            this.assetAssignmentRepository = assetAssignmentRepository;
            this.mapper = mapper;
        }

        public async Task Handle(DeleteAssignmentCommand request, CancellationToken cancellationToken)
        {
            var assetAssignmentToDelete = await assetAssignmentRepository.GetByIdAsync(request.Id);

            if(assetAssignmentToDelete is null)
            {
                throw new NotFoundException("Asset Assignment", request.Id);
            }

            await assetAssignmentRepository.DeleteAsync(assetAssignmentToDelete);
        }
    }
}
