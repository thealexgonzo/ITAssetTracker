using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Resolutions.Commands.DeleteResolution
{
    public class DeleteResolutionCommand: IRequest
    {
        public int Id { get; set; }
    }
}
