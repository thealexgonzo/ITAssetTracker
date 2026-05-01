namespace ITAssetTracker.DataAccess.Entities;

public class Manufacturer
{
    public int ManufacturerId { get; set; }
    public string Name { get; set; } = string.Empty;


    public List<Model> Models { get; set; } = new();
}
