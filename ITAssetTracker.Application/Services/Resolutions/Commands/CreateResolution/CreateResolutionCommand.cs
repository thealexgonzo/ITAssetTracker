using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Resolutions.Commands.CreateResolution
{
    public class CreateResolutionCommand: IRequest<Guid>
    {
        public string Name { get; set; } = string.Empty;
    }
}
