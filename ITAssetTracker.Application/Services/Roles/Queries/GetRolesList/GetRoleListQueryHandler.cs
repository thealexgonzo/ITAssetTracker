using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsList;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Roles.Queries.GetRolesList
{
    public class GetRoleListQueryHandler : IRequestHandler<GetRoleListQuery, List<RoleListViewModel>>
    {
        private readonly IRoleRepository roleRepository;
        private readonly IMapper mapper;

        public GetRoleListQueryHandler(IRoleRepository roleRepository, IMapper mapper)
        {
            this.roleRepository = roleRepository;
            this.mapper = mapper;
        }

        public async Task<List<RoleListViewModel>> Handle(GetRoleListQuery request, CancellationToken cancellationToken)
        {
            var allRoles = (await roleRepository.ListAllAsync()).ToList();
            return mapper.Map<List<RoleListViewModel>>(allRoles);
        }
    }
}
