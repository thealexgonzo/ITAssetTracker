using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Features.Assets.Commands.DeleteAsset
{
    public class DeleteAssetCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
