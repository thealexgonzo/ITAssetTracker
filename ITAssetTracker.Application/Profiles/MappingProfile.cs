using AutoMapper;
using ITAssetTracker.Application.Services.Assets.Commands.CreateAsset;
using ITAssetTracker.Application.Services.Assets.Commands.UpdateAsset;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsList;
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

            //Asset Status Mappings
            CreateMap<AssetStatus, AssetStatusDTO>().ReverseMap();

            //Asset Product Mappings
            CreateMap<AssetProduct, AssetProductDTO>().ReverseMap();

            //Category Mappings
            CreateMap<Category, CategoryListDTO>().ReverseMap();
        }
    }
}
