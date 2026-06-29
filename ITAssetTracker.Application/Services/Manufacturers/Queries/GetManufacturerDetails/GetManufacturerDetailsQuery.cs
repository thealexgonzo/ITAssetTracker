using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Manufacturers.Queries.GetManufacturerDetails
{
    public class GetManufacturerDetailsQuery: IRequest<ManufacturerDetailsViewModel>
    {
        public Guid Id { get; set; }
    }
}
