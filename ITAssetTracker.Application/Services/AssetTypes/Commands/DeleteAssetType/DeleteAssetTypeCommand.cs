using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetTypes.Commands.DeleteAssetType
{
    public class DeleteAssetTypeCommand: IRequest
    {
        public Guid Id { get; set; }
    }
}
