using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Manufacturers.Commands.DeleteManufacturer
{
    public class DeleteManufacturerCommand: IRequest
    {
        public Guid Id { get; set; }
    }
}
