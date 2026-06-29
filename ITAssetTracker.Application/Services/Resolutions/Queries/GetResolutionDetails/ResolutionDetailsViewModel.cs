using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Resolutions.Queries.GetResolutionDetails
{
    public class ResolutionDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
