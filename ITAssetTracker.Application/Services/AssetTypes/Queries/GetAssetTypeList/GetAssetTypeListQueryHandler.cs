using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetTypes.Queries.GetAssetTypeList
{
    public class GetAssetTypeListQueryHandler : IRequestHandler<GetAssetTypeListQuery, List<AssetTypeListViewModel>>
    {
        private readonly IAssetTypeRepository assetTypeRepository;
        private readonly IMapper mapper;

        public GetAssetTypeListQueryHandler(IAssetTypeRepository assetTypeRepository, IMapper mapper)
        {
            this.assetTypeRepository = assetTypeRepository;
            this.mapper = mapper;
        }

        public async Task<List<AssetTypeListViewModel>> Handle(GetAssetTypeListQuery request, CancellationToken cancellationToken)
        {
            var allAssetTypes = await assetTypeRepository.ListAllAsync();

            return mapper.Map<List<AssetTypeListViewModel>>(allAssetTypes);
        }
    }
}
