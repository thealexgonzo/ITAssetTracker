using ITAssetTracker.Domain.Entities;
using ITAssetTracker.MVC.Utilities.CustomValidation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITAssetTracker.MVC.Models.Asset;

public class AssetForm
{
    public int? AssetId { get; set; }
    [IsNumber(ErrorMessage = "The value must be numeric only.")]
    [Required(ErrorMessage = "You must enter a product tag.")]
    [Range(1, int.MaxValue, ErrorMessage = "Values must be greater than 0")]
    public int? Tag { get; set; }
    [Required(ErrorMessage = "You must enter a product name.")]
    [StringLength(100, ErrorMessage = "Name can't exceed 200 characters.")]
    public string? Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "You must select a value.")]
    public int? AssetProductId { get; set; }
    [StringLength(200, ErrorMessage = "Descriptionn can't exceed 200 characters.")]
    public string? Description { get; set; } = string.Empty;
    [Required(ErrorMessage = "You must select a value.")]
    public int? AssetStatusId { get; set; }
    [Required(ErrorMessage = "Price is required.")]
    [Range(0.01, 999999.99, ErrorMessage = "Price must be between 0.01 and 999,999.99.")]
    [Column(TypeName = "decimal(18,2)")] // Database precision
    public decimal? Price { get; set; }
    [Required(ErrorMessage = "You must enter the asset location.")]
    public string Location { get; set; }
    [Required(ErrorMessage = "You must enter the serial number.")]
    public string SerialNumber { get; set; }
    [Required(ErrorMessage ="A date value must be provided.")]
    [DataType(DataType.Date)]
    public DateTime? PurchaseDate { get; set; }
    [Required(ErrorMessage = "A date value must be provided.")]
    [DataType(DataType.Date)]
    public DateTime? WarrantyExpiryDate { get; set; }

    public List<AssetProduct> AssetProductsList { get; set; } = new();
    public List<AssetStatus> AssetStatusList { get; set; } = new();

    public AssetForm()
    {
        
    }

    public AssetForm(Domain.Entities.Asset entity)
    {
        AssetId = entity.AssetId;
        Tag = entity.Tag;
        Name = entity.Name;
        AssetProductId = entity.AssetProductId;
        AssetStatusId = entity.AssetStatusId;
        Description = entity.Description;
        Price = entity.Price;
        Location = entity.Location;
        SerialNumber = entity.SerialNumber;
        PurchaseDate = entity.PurchaseDate;
        WarrantyExpiryDate = entity.WarrantyExpiryDate;
    }

    public Domain.Entities.Asset ToEntity()
    {
        return new Domain.Entities.Asset()
        {
            AssetId = AssetId ?? 0,
            Tag = Tag ?? 0,
            Name = Name,
            AssetProductId = AssetProductId ?? 0,
            AssetStatusId = AssetStatusId ?? 0,
            Description = Description,
            Price = Price.HasValue ? (decimal)Price.Value : 0.00M,
            Location = Location,
            SerialNumber = SerialNumber,
            PurchaseDate = PurchaseDate.HasValue ? (DateTime)PurchaseDate : DateTime.Today,
            WarrantyExpiryDate = WarrantyExpiryDate.HasValue ? (DateTime)WarrantyExpiryDate : DateTime.Today
        };  
    }
}