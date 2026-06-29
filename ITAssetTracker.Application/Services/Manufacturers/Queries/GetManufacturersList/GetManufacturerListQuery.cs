using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Manufacturers.Queries.GetManufacturersList
{
    public class GetManufacturerListQuery: IRequest<List<ManufacturerListViewModel>>
    {
    }
}
