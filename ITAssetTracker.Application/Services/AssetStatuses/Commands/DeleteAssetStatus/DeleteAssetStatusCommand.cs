using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetStatuses.Commands.DeleteAssetStatus;

public class DeleteAssetStatusCommand: IRequest
{
    public int Id { get; set; }
}
