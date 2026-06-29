using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetTypes.Queries.GetAssetTypeDetails
{
    public class CategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
