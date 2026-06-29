using MediatR;

namespace ITAssetTracker.Application.Services.Manufacturers.Commands.CreateManufacturer;

public class CreateManufacturerCommand: IRequest<Guid>
{
    public string Name { get; set; } = string.Empty;
}
