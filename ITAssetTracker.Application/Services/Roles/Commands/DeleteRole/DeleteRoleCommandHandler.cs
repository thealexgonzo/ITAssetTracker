using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Roles.Commands.DeleteRole
{
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand>
    {
        private readonly IRoleRepository roleRepository;
        private readonly IMapper mapper;

        public DeleteRoleCommandHandler(IRoleRepository roleRepository, IMapper mapper)
        {
            this.roleRepository = roleRepository;
            this.mapper = mapper;
        }

        public async Task Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var roleToDelete = await roleRepository.GetByIdAsync(request.Id);

            if (roleToDelete is null)
            {
                throw new NotFoundException("Role", request.Id);
            }

            await roleRepository.DeleteAsync(roleToDelete);
        }
    }
}
