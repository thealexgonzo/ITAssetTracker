using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Exceptions;

namespace ITAssetTracker.Domain.Entities;

public class AssetStatus: AuditableEntity
{
    public string Name { get; private set; } = string.Empty;
    public List<Asset> Assets { get; set; } = new();


    public AssetStatus(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new BusinessRuleExceptions($"{nameof(name)} is required.");
        }

        
        Name = name;
    }
}
