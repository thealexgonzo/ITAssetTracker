using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Roles.Queries.GetRoleDetails
{
    public class GetRoleDetailsQueryHandler : IRequestHandler<GetRoleDetailsQuery, RoleDetailsViewModel>
    {
        private readonly IRoleRepository roleRepository;
        private readonly IMapper mapper;

        public GetRoleDetailsQueryHandler(IRoleRepository roleRepository, IMapper mapper)
        {
            this.roleRepository = roleRepository;
            this.mapper = mapper;
        }

        public async Task<RoleDetailsViewModel> Handle(GetRoleDetailsQuery request, CancellationToken cancellationToken)
        {
            var role = await roleRepository.GetByIdAsync(request.Id)!;

            if (role is null)
            {
                throw new NotFoundException("Role", request.Id);
            }

            var roleDetailViewModel = mapper.Map<RoleDetailsViewModel>(role);

            return roleDetailViewModel;
        }
    }
}
