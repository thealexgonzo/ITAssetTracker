using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Domain.ValueObjects;

namespace ITAssetTracker.Application.Features.Assets.Queries.GetAssetDetails
{
    public class AssetDetailsDTO
    {
        public Guid AssetId { get;  set; }
        public string Tag { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int AssetProductId { get; set; }
        public AssetProduct AssetProducts { get; set; } = null!;
        public int AssetStatusId { get; set; }
        public AssetStatus AssetStatuses { get; set; } = null!;
        public decimal Price { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = null!;
        // DateRange = Purchase date & Warranty Expiry date.
        public DateRange DateRange { get; set; } = null!;
    }
}
