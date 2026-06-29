using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Domain.ValueObjects;

namespace ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails
{
    public class AssetDetailsViewModel
    {
        public Guid Id { get;  set; }
        public string Tag { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public Guid AssetProductId { get; set; }
        public AssetProduct AssetProducts { get; set; } = null!;
        public Guid AssetStatusId { get; set; }
        public AssetStatus AssetStatuses { get; set; } = null!;
        public decimal Price { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = null!;
        public DateRange DateRange { get; set; } = null!;
    }
}
