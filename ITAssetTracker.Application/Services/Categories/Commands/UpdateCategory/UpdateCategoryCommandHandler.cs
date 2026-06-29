using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Commands.UpdateAsset;
using ITAssetTracker.Domain.Entities;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand>
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }
        public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category? categoryToUpdate = await categoryRepository.GetByIdAsync(request.Id);

            if (categoryToUpdate is null)
            {
                throw new NotFoundException("Asset", request.Id);
            }

            UpdateCategoryCommandValidator validator = new UpdateCategoryCommandValidator();
            ValidationResult validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            mapper.Map(request, categoryToUpdate, typeof(UpdateCategoryCommand), typeof(Asset));
            await categoryRepository.UpdateAsync(categoryToUpdate); // TODO: Need to add validation, the asset cannot be null if you want to update it
        }
    }
}
