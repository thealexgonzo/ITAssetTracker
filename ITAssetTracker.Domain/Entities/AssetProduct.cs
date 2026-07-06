using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Exceptions;

namespace ITAssetTracker.Domain.Entities;

public class AssetProduct: AuditableEntity
{
    public string Name { get; private set; } = string.Empty;
    public int ManufacturerId { get; private set; }
    public Manufacturer Manufacturer { get; set; } = null!;
    public int AssetTypeId { get; private set; }
    public AssetType AssetType { get; set; } = null!;
    public List<Asset> Assets { get; set; } = new();

    public AssetProduct(string name, int manufacturerId, int assetTypeId)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new BusinessRuleExceptions($"{nameof(name)} is required.");
        }

        
        Name = name;
        AssetTypeId = assetTypeId;
    }
}
