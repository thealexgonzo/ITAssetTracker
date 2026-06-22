using AutoMapper;
using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.AssetProducts.Queries.GetAssetProductDetails;

public class GetAssetProductDetailsQueryHandler : IRequestHandler<GetAssetProductDetailsQuery, AssetProductDetailsViewModel>
{
    private readonly IAsyncRepository<AssetProduct> assetProductRepository;
    private readonly IAsyncRepository<Manufacturer> manufacturerRepository;
    private readonly IAsyncRepository<AssetType> assetTypeRepository;
    private readonly IMapper mapper;

    public GetAssetProductDetailsQueryHandler(IAsyncRepository<AssetProduct> assetProductRepository,
        IAsyncRepository<Manufacturer> manufacturerRepository, IAsyncRepository<AssetType> assetTypeRepository,
        IMapper mapper)
    {
        this.assetProductRepository = assetProductRepository;
        this.manufacturerRepository = manufacturerRepository;
        this.assetTypeRepository = assetTypeRepository;
        this.mapper = mapper;
    }
    public async Task<AssetProductDetailsViewModel> Handle(GetAssetProductDetailsQuery request, CancellationToken cancellationToken)
    {
        var assetProduct = await assetProductRepository.GetByIdAsync(request.Id);

        if(assetProduct is null)
        {
            throw new NotFoundException("Asset Product", request.Id);
        }

        var assetProductDetailViewModel = mapper.Map<AssetProductDetailsViewModel>(assetProduct);

        var manufacturer = await manufacturerRepository.GetByIdAsync(assetProduct.ManufacturerId);
        var assetType = await assetTypeRepository.GetByIdAsync(assetProduct.AssetTypeId);

        assetProductDetailViewModel.Manufacturer = mapper.Map<Manufacturer>(manufacturer);
        assetProductDetailViewModel.AssetType = mapper.Map<AssetType>(assetType);

        return assetProductDetailViewModel;
    }
}
