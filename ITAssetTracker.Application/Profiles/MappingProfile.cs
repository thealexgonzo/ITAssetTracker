using AutoMapper;
using ITAssetTracker.Application.Features.Assets.Commands.CreateAsset;
using ITAssetTracker.Application.Features.Assets.Commands.DeleteAsset;
using ITAssetTracker.Application.Features.Assets.Commands.UpdateAsset;
using ITAssetTracker.Application.Features.Assets.Queries.GetAssetDetails;
using ITAssetTracker.Application.Features.Assets.Queries.GetAssetsList;
using ITAssetTracker.Application.Features.Categories.Queries.GetCategoriesList;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //Asset
            CreateMap<Asset, AssetListDTO>().ReverseMap();
            CreateMap<Asset, AssetDetailsDTO>().ReverseMap();
            CreateMap<Asset, CreateAssetCommand>().ReverseMap();
            CreateMap<Asset, UpdateAssetCommand>().ReverseMap();
            //Asset Status
            CreateMap<AssetStatus, AssetStatusesDTO>().ReverseMap();
            //Asset Product
            CreateMap<AssetProduct, AssetProductsDTO>().ReverseMap();
            //Category
            CreateMap<Category, CategoryListDTO>().ReverseMap();
        }
    }
}
