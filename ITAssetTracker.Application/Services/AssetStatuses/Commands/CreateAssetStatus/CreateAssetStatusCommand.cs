using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.AssetStatuses.Commands.CreateAssetStatus;

public class CreateAssetStatusCommand: IRequest<int>
{
    public string Name { get; private set; } = string.Empty;
}
