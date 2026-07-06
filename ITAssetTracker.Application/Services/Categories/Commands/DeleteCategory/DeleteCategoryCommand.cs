using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Categories.Commands.DeleteCategory
{
    public class DeleteCategoryCommand: IRequest
    {
        public int Id { get; set; }
    }
}
