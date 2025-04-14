namespace Fahrzeugverleih;

public class Vehicle(
    int id,
    string manufacturer,
    string model,
    int year,
    int mileage,
    bool isAvailable,
    double rentalCost)
{
    public int Id { get; set; } = id;
    public string Manufacturer { get; set; } = manufacturer;
    public string Model { get; set; } = model;
    public int Year { get; set; } = year;
    public int Mileage { get; set; } = mileage;
    public bool IsAvailable { get; set; } = isAvailable;
    public double RentalCost { get; set; } = rentalCost;
    
    public double CalculateRentalCost(int days)
    {
        return days * RentalCost;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Manufacturer: {Manufacturer}, Model: {Model}, Year: {Year}, Mileage: {Mileage} km, Available: {IsAvailable}, Rental Cost per Day: {RentalCost:C}";
    }
}