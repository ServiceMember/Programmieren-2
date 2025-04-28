namespace Fahrzeugverleih;

public class Vehicle
{
    private static int _id = 0;
    public int Id { get; private set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public uint Mileage { get; set; }
    public bool IsAvailable { get; set; }
    public double RentalCost { get; set; }

    public Vehicle(
        string manufacturer,
        string model,
        int year,
        uint mileage,
        bool isAvailable,
        double rentalCost)
    {
        Id = _id++;
        Manufacturer = manufacturer;
        Model = model;
        Year = year;
        Mileage = mileage;
        IsAvailable = isAvailable;
        RentalCost = rentalCost;
    }
    public virtual double CalculateRentalCost(int days)
    {
        return days * RentalCost;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Manufacturer: {Manufacturer}, Model: {Model}, Year: {Year}, Mileage: {Mileage} km, Available: {IsAvailable}, Rental Cost per Day: {RentalCost:C}";
    }
}