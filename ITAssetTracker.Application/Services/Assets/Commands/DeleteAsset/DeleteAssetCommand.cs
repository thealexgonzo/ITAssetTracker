using MediatR;

namespace ITAssetTracker.Application.Services.Assets.Commands.DeleteAsset;

public class DeleteAssetCommand : IRequest
{
    public int Id { get; set; }
}
