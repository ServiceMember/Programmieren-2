namespace TestFahrzeugverleih;
using Fahrzeugverleih;

[TestFixture]
public class TestVehicle
{
    private Vehicle _vehicle;
    [SetUp]
    public void Setup()
    {
        _vehicle = new Vehicle(
            manufacturer:"Toyota", 
            model:"Corolla", 
            year:2020, 
            mileage:15000, 
            isAvailable:true, 
            rentalCost:51.0);
    }

    [Test]
    public void Constructor()
    {
        
        Assert.That(_vehicle, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(_vehicle.Manufacturer, Is.EqualTo("Toyota"));
            Assert.That(_vehicle.Model, Is.EqualTo("Corolla"));
            Assert.That(_vehicle.Year, Is.EqualTo(2020));
            Assert.That(_vehicle.Mileage, Is.EqualTo(15000));
            Assert.That(_vehicle.IsAvailable, Is.EqualTo(true));
            Assert.That(_vehicle.RentalCost, Is.EqualTo(51.0));
        });
    }
    
    [Test]
    public void CalculateRentalCost()
    {
        Assert.That(_vehicle.CalculateRentalCost(3), Is.EqualTo(51*3));
    }
}