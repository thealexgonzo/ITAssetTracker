namespace ITAssetTracker.Application.Features.Assets.Queries.GetAssetsList
{
    public class AssetListDTO
    {
        public Guid AssetId { get; set; }
        public string Name { get; set; } = null!;
    }
}
