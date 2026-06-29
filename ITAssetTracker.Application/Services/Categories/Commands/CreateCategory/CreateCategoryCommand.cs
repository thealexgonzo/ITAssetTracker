using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand: IRequest<Guid>
    {
        public string Name { get; set; } = string.Empty;
    }
}
