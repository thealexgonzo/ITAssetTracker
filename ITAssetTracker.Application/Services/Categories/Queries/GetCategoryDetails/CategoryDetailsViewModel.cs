using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Categories.Queries.GetCategoryDetails
{
    public class CategoryDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
