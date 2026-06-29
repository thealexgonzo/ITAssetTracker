using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Categories.Commands.DeleteCategory
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand>
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }
        public async Task Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryToDelete = await categoryRepository.GetByIdAsync(request.Id);

            if (categoryToDelete is null)
            {
                throw new NotFoundException("Category", request.Id);
            }

            await categoryRepository.DeleteAsync(categoryToDelete);
        }
    }
}
