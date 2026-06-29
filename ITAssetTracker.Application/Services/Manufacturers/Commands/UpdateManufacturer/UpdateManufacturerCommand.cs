using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Manufacturers.Commands.UpdateManufacturer
{
    public class UpdateManufacturerCommand: IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
