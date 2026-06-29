using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Users.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public DeleteUserCommandHandler (IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public async Task Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var userToDelete = await userRepository.GetByIdAsync(request.Id);

            if (userToDelete is null)
            {
                throw new NotFoundException("User", request.Id);
            }

            await userRepository.DeleteAsync(userToDelete);
        }
    }
}
