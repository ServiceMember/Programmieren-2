namespace TestFahrzeugverleih;
using Fahrzeugverleih;

public class TestVehicle
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Constructor()
    {
        Vehicle vehicle = new Vehicle(
            id:1, 
            manufacturer:"Toyota", 
            model:"Corolla", 
            year:2020, 
            mileage:15000, 
            isAvailable:true, 
            rentalCost:50.0);
        
        Assert.That(vehicle.Id, Is.EqualTo(1));
        Assert.That(vehicle.Manufacturer, Is.EqualTo("Toyota"));
        Assert.That(vehicle.Model, Is.EqualTo("Corolla"));
        Assert.That(vehicle.Year, Is.EqualTo(2020));
        Assert.That(vehicle.Mileage, Is.EqualTo(15000));
        Assert.That(vehicle.IsAvailable, Is.EqualTo(true));
        Assert.That(vehicle.RentalCost, Is.EqualTo(50.0));
    }
    
    [Test]
    public void CalculateRentalCost()
    {
        Vehicle vehicle = new Vehicle(
            id:1, 
            manufacturer:"Toyota", 
            model:"Corolla", 
            year:2020, 
            mileage:15000, 
            isAvailable:true, 
            rentalCost:50.99);
        
        Assert.That(vehicle.CalculateRentalCost(3), Is.EqualTo(152.97));
    }
}