using AutoMapper;
using ITAssetTracker.Application.Services.AssetProducts.Commands.CreateAssetProduct;
using ITAssetTracker.Application.Services.AssetProducts.Commands.UpdateAssetProduct;
using ITAssetTracker.Application.Services.AssetProducts.Queries.GetAssetProductDetails;
using ITAssetTracker.Application.Services.AssetProducts.Queries.GetAssetProductList;
using ITAssetTracker.Application.Services.Assets.Commands.CreateAsset;
using ITAssetTracker.Application.Services.Assets.Commands.DeleteAsset;
using ITAssetTracker.Application.Services.Assets.Commands.UpdateAsset;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsExport;
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
using ITAssetTracker.Application.Services.Categories.Commands.CreateCategory;
using ITAssetTracker.Application.Services.Categories.Commands.DeleteCategory;
using ITAssetTracker.Application.Services.Categories.Commands.UpdateCategory;
using ITAssetTracker.Application.Services.Categories.Queries.GetCategoriesList;
using ITAssetTracker.Application.Services.Categories.Queries.GetCategoryDetails;
using ITAssetTracker.Application.Services.Departments.Commands.CreateDepartment;
using ITAssetTracker.Application.Services.Departments.Commands.DeleteDepartment;
using ITAssetTracker.Application.Services.Departments.Commands.UpdateDepartment;
using ITAssetTracker.Application.Services.Departments.Queries.GetDepartmentDetails;
using ITAssetTracker.Application.Services.Departments.Queries.GetDepartmentsList;
using ITAssetTracker.Application.Services.Employees.Commands.CreateEmployee;
using ITAssetTracker.Application.Services.Employees.Commands.DeleteEmployee;
using ITAssetTracker.Application.Services.Employees.Commands.UpdateEmployee;
using ITAssetTracker.Application.Services.Employees.Queries.GetEmployeeDetails;
using ITAssetTracker.Application.Services.Employees.Queries.GetEmployeesList;
using ITAssetTracker.Application.Services.Manufacturers.Commands.CreateManufacturer;
using ITAssetTracker.Application.Services.Manufacturers.Commands.DeleteManufacturer;
using ITAssetTracker.Application.Services.Manufacturers.Commands.UpdateManufacturer;
using ITAssetTracker.Application.Services.Manufacturers.Queries.GetManufacturerDetails;
using ITAssetTracker.Application.Services.Manufacturers.Queries.GetManufacturersList;
using ITAssetTracker.Application.Services.Priorities.Commands.CreatePriorities;
using ITAssetTracker.Application.Services.Priorities.Commands.DeletePriorities;
using ITAssetTracker.Application.Services.Priorities.Commands.UpdatePriorities;
using ITAssetTracker.Application.Services.Priorities.Queries.GetPrioritiesDetails;
using ITAssetTracker.Application.Services.Priorities.Queries.GetPrioritiesList;
using ITAssetTracker.Application.Services.Resolutions.Commands.CreateResolution;
using ITAssetTracker.Application.Services.Resolutions.Commands.DeleteResolution;
using ITAssetTracker.Application.Services.Resolutions.Commands.UpdateResolution;
using ITAssetTracker.Application.Services.Resolutions.Queries.GetResolutionDetails;
using ITAssetTracker.Application.Services.Resolutions.Queries.GetResolutionsList;
using ITAssetTracker.Application.Services.Roles.Commands.CreateRole;
using ITAssetTracker.Application.Services.Roles.Commands.DeleteRole;
using ITAssetTracker.Application.Services.Roles.Commands.UpdateRole;
using ITAssetTracker.Application.Services.Roles.Queries.GetRoleDetails;
using ITAssetTracker.Application.Services.Roles.Queries.GetRolesList;
using ITAssetTracker.Application.Services.SupporTickets.Commands.CreateSupportTicket;
using ITAssetTracker.Application.Services.SupporTickets.Commands.DeleteSupportTicket;
using ITAssetTracker.Application.Services.SupporTickets.Commands.UpdateSupportTicket;
using ITAssetTracker.Application.Services.SupporTickets.Queries.GetSupportTicketDetails;
using ITAssetTracker.Application.Services.SupporTickets.Queries.GetSupportTicketsList;
using ITAssetTracker.Application.Services.TicketStatuses.Commands.CreateTicketStatus;
using ITAssetTracker.Application.Services.TicketStatuses.Commands.DeleteTicketStatus;
using ITAssetTracker.Application.Services.TicketStatuses.Commands.UpdateTicketStatus;
using ITAssetTracker.Application.Services.TicketStatuses.Queries.GetTicketStatusDetails;
using ITAssetTracker.Application.Services.TicketStatuses.Queries.GetTicketStatusList;
using ITAssetTracker.Application.Services.Users.Commands.CreateUser;
using ITAssetTracker.Application.Services.Users.Commands.DeleteUser;
using ITAssetTracker.Application.Services.Users.Commands.UpdateUser;
using ITAssetTracker.Application.Services.Users.Queries.GetUserDetails;
using ITAssetTracker.Application.Services.Users.Queries.GetUsersList;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.Profiles;

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
        CreateMap<AssetStatus, AssetStatusDTO>().ReverseMap();
        CreateMap<AssetProduct, AssetProductDTO>().ReverseMap();
        CreateMap<Category, CategoryListViewModel>().ReverseMap();
        CreateMap<Asset, AssetExportDTO>().ReverseMap();

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
        CreateMap<Asset, Services.Assignments.Queries.GetAssignmentDetails.AssetDTO>().ReverseMap();
        CreateMap<Employee, Services.Assignments.Queries.GetAssignmentDetails.EmployeeDTO>().ReverseMap();


        // ==============================================================

        //Category Mappings
        //Commands
        CreateMap<Category, CreateCategoryCommand>().ReverseMap();
        CreateMap<Category, DeleteCategoryCommand>().ReverseMap();
        CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
        //Queries
        CreateMap<Category, CategoryDetailsViewModel>().ReverseMap();
        CreateMap<Category, CategoryListViewModel>().ReverseMap();


        // ==============================================================

        //Department Mappings
        //Commands
        CreateMap<Department, CreateDepartmentCommand>().ReverseMap();
        CreateMap<Department, DeleteDepartmentCommand>().ReverseMap();
        CreateMap<Department, UpdateDepartmentCommand>().ReverseMap();
        //Queries
        CreateMap<Department, DepartmentDetailsViewModel>().ReverseMap();
        CreateMap<Department, DepartmentListViewModel>().ReverseMap();

        // ==============================================================

        //Employee Mappings
        //Commands
        CreateMap<Employee, CreateEmployeeCommand>().ReverseMap();
        CreateMap<Employee, DeleteEmployeeCommand>().ReverseMap();
        CreateMap<Employee, UpdateEmployeeCommand>().ReverseMap();
        //Queries            
        CreateMap<Employee, EmployeeDetailsViewModel>().ReverseMap();
        CreateMap<Employee, EmployeeListViewModel>().ReverseMap();
        //Employee DTOs
        CreateMap<Department, DepartmentDTO>().ReverseMap();
        CreateMap<User, UserDTO>().ReverseMap();

        // ==============================================================

        //Manufacturer Mappings
        //Commands
        CreateMap<Manufacturer, CreateManufacturerCommand>().ReverseMap();
        CreateMap<Manufacturer, DeleteManufacturerCommand>().ReverseMap();
        CreateMap<Manufacturer, UpdateManufacturerCommand>().ReverseMap();
        //Queries
        CreateMap<Manufacturer, ManufacturerDetailsViewModel>().ReverseMap();
        CreateMap<Manufacturer, ManufacturerListViewModel>().ReverseMap();

        // ==============================================================

        //Priorities
        //Commands
        CreateMap<Priority, CreatePrioritiesCommand>().ReverseMap();
        CreateMap<Priority, DeletePrioritiesCommand>().ReverseMap();
        CreateMap<Priority, UpdatePrioritiesCommand>().ReverseMap();
        //Queries
        CreateMap<Priority, PrioritiesDetailsViewModel>().ReverseMap();
        CreateMap<Priority, PrioritiesListViewModel>().ReverseMap();

        // ==============================================================

        //Resolution
        //Commands
        CreateMap<Resolution, CreateResolutionCommand>().ReverseMap();
        CreateMap<Resolution, DeleteResolutionCommand>().ReverseMap();
        CreateMap<Resolution, UpdateResolutionCommand>().ReverseMap();
        //Queries
        CreateMap<Resolution, ResolutionDetailsViewModel>().ReverseMap();
        CreateMap<Resolution, ResolutionListViewModel>().ReverseMap();

        // ==============================================================

        //Roles
        //Commands
        CreateMap<Role, CreateRoleCommand>().ReverseMap();
        CreateMap<Role, DeleteRoleCommand>().ReverseMap();
        CreateMap<Role, UpdateRoleCommand>().ReverseMap();
        //Queries
        CreateMap<Role, RoleDetailsViewModel>().ReverseMap();
        CreateMap<Role, RoleListViewModel>().ReverseMap();

        // ==============================================================

        //SupportTickets
        //Commands
        CreateMap<SupportTicket, CreateSupportTicketCommand>().ReverseMap();
        CreateMap<SupportTicket, DeleteSupportTicketCommand>().ReverseMap();
        CreateMap<SupportTicket, UpdateSupportTicketCommand>().ReverseMap();
        //Queries
        CreateMap<Role, SupportTicketDetailsViewModel>().ReverseMap();
        CreateMap<Role, SupportTicketListViewModel>().ReverseMap();
        //DTOs
        CreateMap<Asset, Services.SupporTickets.Queries.GetSupportTicketDetails.AssetDTO>().ReverseMap();
        CreateMap<Employee, Services.SupporTickets.Queries.GetSupportTicketDetails.EmployeeDTO>().ReverseMap();
        CreateMap<Priority, PriorityDTO>().ReverseMap();
        CreateMap<TicketStatus, TicketStatusDTO>().ReverseMap();
        CreateMap<Resolution, ResolutionDTO>().ReverseMap();

        // ==============================================================

        //TicketStatuses
        //Commands
        CreateMap<TicketStatus, CreateTicketStatusCommand>().ReverseMap();
        CreateMap<TicketStatus, DeleteTicketStatusCommand>().ReverseMap();
        CreateMap<TicketStatus, UpdateTicketStatusCommand>().ReverseMap();
        //Queries
        CreateMap<TicketStatus, TicketStatusDetailsViewModel>().ReverseMap();
        CreateMap<TicketStatus, TicketStatusListViewModel>().ReverseMap();

        // ==============================================================

        //Users
        //Commands
        CreateMap<User, CreateUserCommand>().ReverseMap();
        CreateMap<User, DeleteUserCommand>().ReverseMap();
        CreateMap<User, UpdateUserCommand>().ReverseMap();
        //Queries
        CreateMap<User, UserDetailsViewModel>().ReverseMap();
        CreateMap<User, UserListViewModel>().ReverseMap();
        //DTOs
        CreateMap<Role, RoleDTO>().ReverseMap();
    }
}
