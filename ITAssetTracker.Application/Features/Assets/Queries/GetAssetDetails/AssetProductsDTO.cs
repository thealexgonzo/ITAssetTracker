using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Features.Assets.Queries.GetAssetDetails
{
    public class AssetProductsDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
