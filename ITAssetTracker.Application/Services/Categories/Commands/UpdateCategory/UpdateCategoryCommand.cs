using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryCommand: IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
