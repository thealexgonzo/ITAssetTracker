using MediatR;
using System.ComponentModel.DataAnnotations;

namespace ITAssetTracker.Application.Services.Assets.Commands.CreateAsset
{
    public class CreateAssetCommand: IRequest<int>
    {
        public string? Tag { get; set; }
        public string? Name { get; set; } = string.Empty;
        public int? AssetProductId { get; set; }
        public string? Description { get; set; } = string.Empty;
        public int? AssetStatusId { get; set; }
        public decimal? Price { get; set; }
        public string? Location { get; set; }
        public string? SerialNumber { get; set; }
        public DateOnly? PurchaseDate { get; set; }
        public DateOnly? WarrantyExpiryDate { get; set; }
    }
}
