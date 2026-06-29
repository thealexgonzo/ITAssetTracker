using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Resolutions.Commands.UpdateResolution
{
    public class UpdateResolutionCommand: IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
