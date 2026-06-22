using AutoMapper;
using ITAssetTracker.Application.Services.AssetProducts.Commands.CreateAssetProduct;
using ITAssetTracker.Application.Services.AssetProducts.Commands.UpdateAssetProduct;
using ITAssetTracker.Application.Services.AssetProducts.Queries.GetAssetProductDetails;
using ITAssetTracker.Application.Services.AssetProducts.Queries.GetAssetProductList;
using ITAssetTracker.Application.Services.Assets.Commands.CreateAsset;
using ITAssetTracker.Application.Services.Assets.Commands.DeleteAsset;
using ITAssetTracker.Application.Services.Assets.Commands.UpdateAsset;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsList;
using ITAssetTracker.Application.Services.AssetStatuses.Commands.CreateAssetStatus;
using ITAssetTracker.Application.Services.Categories.Queries.GetCategoriesList;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.Profiles
{
    // Here we essentially specify which types map to which - this is part of AutoMapper
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //Asset Mappings
            //Queries
            CreateMap<Asset, AssetListViewModel>().ReverseMap();
            CreateMap<Asset, AssetDetailsViewModel>().ReverseMap();
            //Commands
            CreateMap<Asset, CreateAssetCommand>().ReverseMap();
            CreateMap<Asset, UpdateAssetCommand>().ReverseMap();
            CreateMap<Asset, DeleteAssetCommand>().ReverseMap();
            //Asset DTO Mappings
            //Asset Status Mappings
            CreateMap<AssetStatus, AssetStatusDTO>().ReverseMap();
            //Asset Product Mappings
            CreateMap<AssetProduct, AssetProductDTO>().ReverseMap();
            //Category Mappings
            CreateMap<Category, CategoryListDTO>().ReverseMap();

            // ==============================================================
             
            //AssetProduct Mappings
            //Queries
            CreateMap<AssetProduct, AssetProductDetailsViewModel>().ReverseMap();
            CreateMap<AssetProduct, AssetProductListViewModel>().ReverseMap();
            //Commands
            CreateMap<AssetProduct, CreateAssetProductCommand>().ReverseMap();
            CreateMap<AssetProduct, DeleteAssetCommand>().ReverseMap();
            CreateMap<AssetProduct, UpdateAssetProductCommand>().ReverseMap();
            //Asset DTO Mappings
            //Manufacturer Mappings
            CreateMap<Manufacturer, ManufacturerDTO>().ReverseMap();
            CreateMap<AssetType, AssetTypeDTO>().ReverseMap();

            // ==============================================================

            //AssetStatus Mappings
            //Commands
            CreateMap<AssetStatus, CreateAssetStatusCommand>().ReverseMap();
        }
    }
}
