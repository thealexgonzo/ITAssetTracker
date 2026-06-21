using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Exceptions;

namespace ITAssetTracker.Domain.Entities;

public class AssetType: AuditableEntity
{
    public string Name { get; private set; } = string.Empty;
    public Guid CategoryId { get; private set; }
    public Category Category { get; set; } = null!;
    public List<AssetProduct> AssetProducts { get; set; } = new();

    public AssetType(string name, Guid categoryId)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new BusinessRuleExceptions($"{nameof(name)} is required.");
        }

        Id = Guid.CreateVersion7();
        Name = name;
        CategoryId = categoryId;
    }
}
