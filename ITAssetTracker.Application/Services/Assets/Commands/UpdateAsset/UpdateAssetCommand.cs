using MediatR;
using System.ComponentModel.DataAnnotations;

namespace ITAssetTracker.Application.Services.Assets.Commands.UpdateAsset
{
    public class UpdateAssetCommand: IRequest
    {
        public Guid Id { get; set; }
        public string? Tag { get; set; }
        public string? Name { get; set; } = string.Empty;
        public Guid? AssetProductId { get; set; }
        public string? Description { get; set; } = string.Empty;
        public Guid? AssetStatusId { get; set; }
        public decimal? Price { get; set; }
        public string? Location { get; set; }
        public string? SerialNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime? PurchaseDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? WarrantyExpiryDate { get; set; }
    }
}
