using MediatR;

namespace ITAssetTracker.Application.Services.AssetTypes.Commands.CreateAssetType;

public class CreateAssetTypeCommand: IRequest<int>
{
    public string Name { get; private set; } = string.Empty;
    public int CategoryId { get; private set; }
}
