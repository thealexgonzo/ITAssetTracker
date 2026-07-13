namespace ITAssetTracker.Application.Services.Assets.Queries.GetAssetsExport
{
    public class AssetExportFileViewModel
    {
        public string AssetExportFileName { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public byte[]? Data { get; set; }
    }
}