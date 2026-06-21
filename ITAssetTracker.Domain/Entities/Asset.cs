using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Exceptions;

namespace ITAssetTracker.Domain.Entities;

public class Asset: AuditableEntity
{
    public string Tag { get; private set; }
    public string Name { get; private set; }
    public Guid AssetProductId { get; private set; }
    public AssetProduct AssetProducts  { get; set; } = null!;
    public Guid AssetStatusId { get; private set; }
    public AssetStatus AssetStatuses { get; set; } = null!; 
    public decimal Price { get; private set; }
    public string Location { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public string SerialNumber { get; private set; } = null!;
    public DateOnly PurchaseDate { get; private set; }
    public DateOnly WarrantyExpiryDate { get; private set; }

    public List<AssetAssignment> AssetAssignments { get; set; } = new();
    public List<SupportTicket> SupportTickets { get; set; } = new();

    public Asset(string tag, string name, Guid assetProductId, Guid assetStatusId,
        decimal price, string location, string serialNumber, DateOnly purchaseDate, DateOnly warrantyExpiryDate, string description = "")
    {
        if (string.IsNullOrWhiteSpace(tag))
        {
            throw new BusinessRuleExceptions($"The {nameof(tag)} is required");
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new BusinessRuleExceptions($"The {nameof(name)} is required");
        }

        if(price <= 0)
        {
            throw new BusinessRuleExceptions($"The {nameof(price)} must be a positve value.");
        }

        if (string.IsNullOrWhiteSpace(location))
        {
            throw new BusinessRuleExceptions($"The {nameof(location)} is required");
        }
        
        if (string.IsNullOrWhiteSpace(serialNumber))
        {
            throw new BusinessRuleExceptions($"The {nameof(serialNumber)} is required");
        }        

        Id = Guid.CreateVersion7();
        Tag = tag;
        Name = name;
        AssetProductId = assetProductId;
        AssetStatusId = assetStatusId;
        Price = price;
        Location = location;
        Description = description;
        SerialNumber = serialNumber;
        PurchaseDate = purchaseDate;
        WarrantyExpiryDate = warrantyExpiryDate;
    }
}
