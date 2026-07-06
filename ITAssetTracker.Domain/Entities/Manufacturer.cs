using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Exceptions;

namespace ITAssetTracker.Domain.Entities;

public class Manufacturer: AuditableEntity
{
    public string Name { get; private set; } = string.Empty;
    public List<AssetProduct> AssetProducts { get; set; } = new();

    public Manufacturer(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new BusinessRuleExceptions($"{nameof(name)} is required.");
        }

        
        Name = name;
    }
}
