using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Exceptions;

namespace ITAssetTracker.Domain.Entities;

public class AssetProduct: AuditableEntity
{
    public string Name { get; private set; } = string.Empty;
    public Guid ManufacturerId { get; private set; }
    public Manufacturer Manufacturer { get; set; } = null!;
    public Guid AssetTypeId { get; private set; }
    public AssetType AssetType { get; set; } = null!;
    public List<Asset> Assets { get; set; } = new();

    public AssetProduct(string name, Guid manufacturerId, Guid assetTypeId)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new BusinessRuleExceptions($"{nameof(name)} is required.");
        }

        Id = Guid.CreateVersion7();
        Name = name;
        AssetTypeId = assetTypeId;
    }
}
