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
using ITAssetTracker.Application.Services.AssetStatuses.Commands.DeleteAssetStatus;
using ITAssetTracker.Application.Services.AssetStatuses.Commands.UpdateAssetStatus;
using ITAssetTracker.Application.Services.AssetStatuses.Queries.GetAssetStatusDetails;
using ITAssetTracker.Application.Services.AssetStatuses.Queries.GetAssetStatusList;
using ITAssetTracker.Application.Services.AssetTypes.Commands.CreateAssetType;
using ITAssetTracker.Application.Services.AssetTypes.Commands.DeleteAssetType;
using ITAssetTracker.Application.Services.AssetTypes.Commands.UpdateAssetType;
using ITAssetTracker.Application.Services.AssetTypes.Queries.GetAssetTypeDetails;
using ITAssetTracker.Application.Services.AssetTypes.Queries.GetAssetTypeList;
using ITAssetTracker.Application.Services.Assignments.Commands.CreateAssignment;
using ITAssetTracker.Application.Services.Assignments.Commands.DeleteAssignment;
using ITAssetTracker.Application.Services.Assignments.Commands.UpdateAssignment;
using ITAssetTracker.Application.Services.Assignments.Queries.GetAssignmentDetails;
using ITAssetTracker.Application.Services.Assignments.Queries.GetAssignmentsList;
using ITAssetTracker.Application.Services.Categories.Queries.GetCategoriesList;
using ITAssetTracker.Application.Services.Employees.Commands.CreateEmployee;
using ITAssetTracker.Domain.Entities;
using System.Diagnostics.Tracing;

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
            CreateMap<Category, CategoryListViewModel>().ReverseMap();

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
            CreateMap<AssetStatus, DeleteAssetStatusCommand>().ReverseMap();
            CreateMap<AssetStatus, UpdateAssetStatusCommand>().ReverseMap();
            //Queries
            CreateMap<AssetStatus, AssetStatusDetailsViewModel>().ReverseMap();
            CreateMap<AssetStatus, AssetStatusListViewModel>().ReverseMap();

            // ==============================================================

            //AssetType Mappings
            //Commands
            CreateMap<AssetType, CreateAssetTypeCommand>().ReverseMap();
            CreateMap<AssetType, DeleteAssetTypeCommand>().ReverseMap();
            CreateMap<AssetType, UpdateAssetTypeCommand>().ReverseMap();
            //Queries
            CreateMap<AssetType, AssetTypeDetailsViewModel>().ReverseMap();
            CreateMap<AssetType, AssetTypeListViewModel>().ReverseMap();
            //AssetType DTO Mappings
            CreateMap<Category, CategoryDTO>().ReverseMap();

            // ==============================================================

            //AssetAssignment Mappings
            //Commands
            CreateMap<AssetAssignment, CreateAssignmentCommand>().ReverseMap();
            CreateMap<AssetAssignment, DeleteAssignmentCommand>().ReverseMap();
            CreateMap<AssetAssignment, UpdateAssignmentCommand>().ReverseMap();
            //Queries
            CreateMap<AssetAssignment, AssignmentDetailsViewModel>().ReverseMap();
            CreateMap<AssetAssignment, AssignmentListViewModel>().ReverseMap();
            //AssetAssignment DTO
            CreateMap<Asset, AssetDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();


            // ==============================================================

            //Category Mappings

            // ==============================================================

            //Department Mappings

            // ==============================================================

            //Employee Mappings
            //Commands
            CreateMap<Employee, CreateEmployeeCommand>().ReverseMap();
        }
    }
}
