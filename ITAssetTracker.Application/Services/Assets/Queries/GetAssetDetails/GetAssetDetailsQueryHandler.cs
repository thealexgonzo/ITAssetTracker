using AutoMapper;
using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;

public class GetAssetDetailsQueryHandler : IRequestHandler<GetAssetDetailsQuery, AssetDetailsViewModel>
{
    private readonly IAssetRepository assetRepository;
    private readonly IAsyncRepository<AssetProduct> assetProductRepository;
    private readonly IAsyncRepository<AssetStatus> assetStatusRepository;
    private readonly IMapper mapper;

    public GetAssetDetailsQueryHandler(IAssetRepository assetRepository, 
        IAsyncRepository<AssetProduct> assetProductRepository, 
        IAsyncRepository<AssetStatus> assetStatusRepository, IMapper mapper)
    {
        this.assetRepository = assetRepository;
        this.assetProductRepository = assetProductRepository;
        this.assetStatusRepository = assetStatusRepository;
        this.mapper = mapper;
    }

    public async Task<AssetDetailsViewModel> Handle(GetAssetDetailsQuery request, CancellationToken cancellationToken)
    {
        Asset? asset = await assetRepository.GetByIdAsync(request.Id)!;

        if (asset is null)
        {
            throw new NotFoundException("Asset", request.Id);
        }

        AssetDetailsViewModel assetDetailViewModel =  mapper.Map<AssetDetailsViewModel>(asset);

        //NOTE: Do I need these at all?
        // When returning an Asset, I don't think I need to return additional objects...
        //AssetProduct? assetProduct = await assetProductRepository.GetByIdAsync(asset.AssetProductId)!;
        //AssetStatus? assetStatus = await assetStatusRepository.GetByIdAsync(asset.AssetStatusId)!;

        //assetDetailViewModel.AssetProducts = mapper.Map<AssetProduct>(assetProduct);
        //assetDetailViewModel.AssetStatuses = mapper.Map<AssetStatus>(assetStatus);

        return assetDetailViewModel;
    }
}
