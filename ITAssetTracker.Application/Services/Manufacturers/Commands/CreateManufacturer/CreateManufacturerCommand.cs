using MediatR;

namespace ITAssetTracker.Application.Services.Manufacturers.Commands.CreateManufacturer;

public class CreateManufacturerCommand: IRequest<int>
{
    public string Name { get; set; } = string.Empty;
}
