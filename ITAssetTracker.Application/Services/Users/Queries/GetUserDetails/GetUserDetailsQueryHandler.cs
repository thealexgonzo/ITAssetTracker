using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Users.Queries.GetUserDetails
{
    public class GetUserDetailsQueryHandler : IRequestHandler<GetUserDetailsQuery, UserDetailsViewModel>
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        private readonly IRoleRepository roleRepository;

        public GetUserDetailsQueryHandler(IUserRepository userRepository, IMapper mapper, IRoleRepository roleRepository)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
            this.roleRepository = roleRepository;
        }

        public async Task<UserDetailsViewModel> Handle(GetUserDetailsQuery request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetByIdAsync(request.Id)!;

            if (user is null)
            {
                throw new NotFoundException("User", request.Id);
            }

            var userDetailViewModel = mapper.Map<UserDetailsViewModel>(user);

            var role = await roleRepository.GetByIdAsync(user.RoleId)!;

            userDetailViewModel.Role = mapper.Map<Role>(role);

            return userDetailViewModel;
        }
    }
}
