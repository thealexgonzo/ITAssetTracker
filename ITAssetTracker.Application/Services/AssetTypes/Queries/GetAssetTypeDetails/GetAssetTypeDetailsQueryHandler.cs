using AutoMapper;
using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetTypes.Queries.GetAssetTypeDetails
{
    public class GetAssetTypeDetailsQueryHandler : IRequestHandler<GetAssetTypeDetailsQuery, AssetTypeDetailsViewModel>
    {
        private readonly IAssetTypeRepository assetTypeRepository;
        private readonly IMapper mapper;
        private readonly IAsyncRepository<Category> categoryRepository;

        public GetAssetTypeDetailsQueryHandler(IAssetTypeRepository assetTypeRepository, IMapper mapper, IAsyncRepository<Category> categoryRepository)
        {
            this.assetTypeRepository = assetTypeRepository;
            this.mapper = mapper;
            this.categoryRepository = categoryRepository;
        }
        public async Task<AssetTypeDetailsViewModel> Handle(GetAssetTypeDetailsQuery request, CancellationToken cancellationToken)
        {
            AssetType? assetType = await assetTypeRepository.GetByIdAsync(request.Id);

            if (assetType is null)
            {
                throw new NotFoundException("Asset Type", request.Id);
            }

            AssetTypeDetailsViewModel assetTypeDetailViewModel = mapper.Map<AssetTypeDetailsViewModel>(assetType);
            Category? category = await categoryRepository.GetByIdAsync(assetType.CategoryId);

            assetTypeDetailViewModel.Categories = mapper.Map<Category>(category);

            return assetTypeDetailViewModel;
        }
    }
}
