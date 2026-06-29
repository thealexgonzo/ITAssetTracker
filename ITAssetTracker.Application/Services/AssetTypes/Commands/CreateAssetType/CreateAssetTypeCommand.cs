using MediatR;

namespace ITAssetTracker.Application.Services.AssetTypes.Commands.CreateAssetType;

public class CreateAssetTypeCommand: IRequest<Guid>
{
    public string Name { get; private set; } = string.Empty;
    public Guid CategoryId { get; private set; }
}
