namespace WebApplication1.App.Domain;

public class Vehicle
{
    public int Id { get; set; }
    public string Plate { get; set; }
    public string Photo { get; set; }
    public string CirculationCard { get; set; }
    public BrandVehicle BrandVehicle { get; set; }
    public int BrandVehicleId { get; set; }
    public Courier Courier { get; set; }
    public int CourierId { get; set; }
}