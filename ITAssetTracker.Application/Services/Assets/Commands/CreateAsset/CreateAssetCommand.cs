using MediatR;
using System.ComponentModel.DataAnnotations;

namespace ITAssetTracker.Application.Services.Assets.Commands.CreateAsset
{
    public class CreateAssetCommand: IRequest<Guid>
    {
        public string? Tag { get; set; }
        public string? Name { get; set; } = string.Empty;
        public Guid? AssetProductId { get; set; }
        public string? Description { get; set; } = string.Empty;
        public Guid? AssetStatusId { get; set; }
        public decimal? Price { get; set; }
        public string? Location { get; set; }
        public string? SerialNumber { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? WarrantyExpiryDate { get; set; }
    }
}
