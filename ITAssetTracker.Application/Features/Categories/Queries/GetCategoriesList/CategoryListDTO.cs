using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Features.Categories.Queries.GetCategoriesList
{
    public class CategoryListDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
