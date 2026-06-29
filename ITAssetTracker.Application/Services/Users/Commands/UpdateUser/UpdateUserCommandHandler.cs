using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Commands.UpdateAsset;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var userToUpdate = await userRepository.GetByIdAsync(request.Id);

            if (userToUpdate is null)
            {
                throw new NotFoundException("User", request.Id);
            }

            var validator = new UpdateUserCommandValidator();
            ValidationResult validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            mapper.Map(request, userToUpdate, typeof(UpdateUserCommand), typeof(User));
            await userRepository.UpdateAsync(userToUpdate); // TODO: Need to add validation, the asset cannot be null if you want to update it
        }
    }
}
