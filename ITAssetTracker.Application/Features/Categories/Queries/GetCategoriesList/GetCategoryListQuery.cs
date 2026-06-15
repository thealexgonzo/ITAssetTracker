using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoryListQuery: IRequest<List<CategoryListDTO>>
    {
    }
}
