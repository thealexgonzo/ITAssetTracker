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

namespace ITAssetTracker.Application.Services.Roles.Commands.UpdateRole
{
    public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand>
    {
        private readonly IRoleRepository roleRepository;
        private readonly IMapper mapper;

        public UpdateRoleCommandHandler(IRoleRepository roleRepository, IMapper mapper)
        {
            this.roleRepository = roleRepository;
            this.mapper = mapper;
        }

        public async Task Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            var roleToUpdate = await roleRepository.GetByIdAsync(request.Id);

            if (roleToUpdate is null)
            {
                throw new NotFoundException("Role", request.Id);
            }

            var validator = new UpdateRoleCommandValidator();
            ValidationResult validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            mapper.Map(request, roleToUpdate, typeof(UpdateRoleCommand), typeof(Role));
            await roleRepository.UpdateAsync(roleToUpdate); // TODO: Need to add validation, the asset cannot be null if you want to update it
        }
    }
}
