using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Exceptions;

namespace ITAssetTracker.Domain.Entities;

public class Category: AuditableEntity
{
    public string Name { get; private set; } = string.Empty;
    public List<AssetType> AssetTypes { get; set; } = new();

    public Category(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new BusinessRuleExceptions($"{nameof(name)} is required.");
        }

        Id = Guid.CreateVersion7();
        Name = name;
    }
}
