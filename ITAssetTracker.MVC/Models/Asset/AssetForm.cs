using ITAssetTracker.Infrastructure.Entities;
using System.ComponentModel.DataAnnotations;

namespace ITAssetTracker.MVC.Models.Asset;

public class AssetForm
{
    public int? AssetId { get; set; }
    [Required]    
    public int Tag { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public int ModelId { get; set; }
    [Required]
    public string Description { get; set; } = string.Empty;

    //public Model Models { get; set; } = null!;
    //public List<AssetAssignment> AssetAssignments { get; set; } = new();
    public List<Model> ModelsList { get; set; } = new();
    public List<AssetType> AssetTypeList { get; set; } = new();
    public List<Category> CategoryList { get; set; } = new();
    public List<Manufacturer> ManufacturerList { get; set; } = new();

    public AssetForm()
    {
        
    }

    public AssetForm(Infrastructure.Entities.Asset entity)
    {
        AssetId = entity.AssetId;
        Tag = entity.Tag;
        Name = entity.Name;
        ModelId = entity.ModelId;
        Description = entity.Description;
        //Models = entity.Models;
        //AssetAssignments = entity.AssetAssignments;
    }

    public Infrastructure.Entities.Asset ToEntity()
    {
        return new Infrastructure.Entities.Asset()
        {
            AssetId = AssetId ?? 0,
            Tag = Tag,
            Name = Name,
            ModelId = ModelId,
            Description = Description,
            //Models = Models,
            //AssetAssignments = AssetAssignments
        };  
    }
}