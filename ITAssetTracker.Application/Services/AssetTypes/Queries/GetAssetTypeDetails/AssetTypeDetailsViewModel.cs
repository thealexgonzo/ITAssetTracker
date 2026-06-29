using ITAssetTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetTypes.Queries.GetAssetTypeDetails
{
    public class AssetTypeDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; private set; } = string.Empty;
        public Guid CategoryId { get; private set; }
        public Category Categories { get; set; } = null!;
    }
}
