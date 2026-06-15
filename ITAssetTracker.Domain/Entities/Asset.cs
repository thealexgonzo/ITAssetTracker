using ITAssetTracker.Domain.Exceptions;
using ITAssetTracker.Domain.ValueObjects;

namespace ITAssetTracker.Domain.Entities;

public class Asset
{
    public Guid AssetId { get; private set; }
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
    // DateRange = Purchase date & Warranty Expiry date.
    public DateRange DateRange { get; private set; }

    public List<AssetAssignment> AssetAssignments { get; set; } = new();
    public List<SupportTicket> SupportTickets { get; set; } = new();
    public List<AssetHistory> AssetHistories { get; set; } = new();

    public Asset(string tag, string name, Guid assetProductId, Guid assetStatusId,
        decimal price, string location, string serialNumber, DateRange dateRange, string description = "")
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

        AssetId = Guid.CreateVersion7();
        Tag = tag;
        Name = name;
        AssetProductId = assetProductId;
        AssetStatusId = assetStatusId;
        Price = price;
        Location = location;
        Description = description;
        SerialNumber = serialNumber;
        DateRange = dateRange;        
    }
}
