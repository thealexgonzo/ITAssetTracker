using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Exceptions;

namespace ITAssetTracker.Domain.Entities;

public class AssetType: AuditableEntity
{
    public string Name { get; private set; } = string.Empty;
    public int CategoryId { get; private set; }
    public Category Category { get; set; } = null!;
    public List<AssetProduct> AssetProducts { get; set; } = new();

    public AssetType(string name, int categoryId)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new BusinessRuleExceptions($"{nameof(name)} is required.");
        }

        
        Name = name;
        CategoryId = categoryId;
    }
}
