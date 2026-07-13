using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Assets.Queries.GetAssetsExport
{
    public class AssetExportDTO
    {
        public int Id { get; set; }
        public string Tag { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int AssetProductId { get; set; }
        public int AssetStatusId { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = null!;
        public DateOnly PurchaseDate { get; set; }
        public DateOnly WarrantyExpiryDate { get; set; }
    }
}
