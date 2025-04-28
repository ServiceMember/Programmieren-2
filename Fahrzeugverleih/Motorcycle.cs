namespace Fahrzeugverleih;

public class Motorcycle : Vehicle
{
    public int WheelCount { get; set; }
    public double EngineDisplacement { get; set; } // in ccm
    public string Type { get; set; } // e.g., Cruiser, Sport, Touring
    
    public Motorcycle(string manufacturer, string model, int year, uint mileage, bool isAvailable, double rentalCost, int wheelCount, double engineDisplacement, string type) : base(manufacturer, model, year, mileage, isAvailable, rentalCost)
    {
        WheelCount = wheelCount;
        EngineDisplacement = engineDisplacement;
        Type = type;
    }
}