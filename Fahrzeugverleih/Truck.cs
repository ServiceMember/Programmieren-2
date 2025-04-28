namespace Fahrzeugverleih;

public class Truck : Vehicle
{
    public Truck(string manufacturer, string model, int year, uint mileage, bool isAvailable, double rentalCost, double loadCapacity, int axleCount, double loadingArea, double rentalCostPerSquareMeter) : base(manufacturer, model, year, mileage, isAvailable, rentalCost)
    {
        LoadCapacity = loadCapacity;
        AxleCount = axleCount;
        LoadingArea = loadingArea;
        RentalCostPerSquareMeter = rentalCostPerSquareMeter;
    }

    public double LoadCapacity { get; set; } // in tons
    public int AxleCount { get; set; }
    public double LoadingArea { get; set; } // in square meters
    public double RentalCostPerSquareMeter { get; set; } // in currency per square meter

    public override double CalculateRentalCost(int days)
    {
        return base.CalculateRentalCost(days) + RentalCostPerSquareMeter * LoadingArea;
    }
}