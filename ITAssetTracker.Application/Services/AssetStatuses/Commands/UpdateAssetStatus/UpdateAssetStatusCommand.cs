using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetStatuses.Commands.UpdateAssetStatus;

public class UpdateAssetStatusCommand: IRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
