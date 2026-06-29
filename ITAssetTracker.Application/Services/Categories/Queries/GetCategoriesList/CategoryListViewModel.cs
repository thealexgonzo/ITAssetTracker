using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Categories.Queries.GetCategoriesList
{
    public class CategoryListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
