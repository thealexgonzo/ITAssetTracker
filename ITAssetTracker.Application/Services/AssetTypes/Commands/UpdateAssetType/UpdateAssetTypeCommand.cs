using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetTypes.Commands.UpdateAssetType
{
    public class UpdateAssetTypeCommand: IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
