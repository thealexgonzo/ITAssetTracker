using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Categories.Queries.GetCategoryDetails
{
    public class GetCategoryDetailsQueryHandler : IRequestHandler<GetCategoryDetailsQuery, CategoryDetailsViewModel>
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public GetCategoryDetailsQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }
        public async Task<CategoryDetailsViewModel> Handle(GetCategoryDetailsQuery request, CancellationToken cancellationToken)
        {

            var category = await categoryRepository.GetByIdAsync(request.Id)!;

            if (category is null)
            {
                throw new NotFoundException("Asset", request.Id);
            }

            var categoryDetailsViewModel = mapper.Map<CategoryDetailsViewModel>(category);

            return categoryDetailsViewModel;
        }
    }
}
