using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Categories.Queries.GetCategoryDetails
{
    public class GetCategoryDetailsQuery: IRequest<CategoryDetailsViewModel>
    {
        public int Id { get; set; }
    }
}
