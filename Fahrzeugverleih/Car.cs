namespace Fahrzeugverleih;

public class Car : Vehicle
{
    public int DoorCount { get; set; }
    public string FuelType { get; set; }
    public double TrunkVolume { get; set; } // in liters
    
    public Car(
        string manufacturer,
        string model,
        int year,
        uint mileage,
        bool isAvailable,
        double rentalCost,
        int doorCount,
        string fuelType,
        double trunkVolume)
        : base(manufacturer, model, year, mileage, isAvailable, rentalCost)
    {
        DoorCount = doorCount;
        FuelType = fuelType;
        TrunkVolume = trunkVolume;
    }
}