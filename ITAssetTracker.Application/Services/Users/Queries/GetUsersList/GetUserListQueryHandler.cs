using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsList;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Users.Queries.GetUsersList
{
    public class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, List<UserListViewModel>>
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public GetUserListQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<List<UserListViewModel>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            var allUsers = (await userRepository.ListAllAsync()).ToList();
            return mapper.Map<List<UserListViewModel>>(allUsers);
        }
    }
}
