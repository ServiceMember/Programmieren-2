namespace TestFahrzeugverleih;
using Fahrzeugverleih;

[TestFixture]
public class UnitTestCar
{
    private Car _myCar;
    
    [SetUp]
    public void Setup()
    {
        _myCar = new Car(
            manufacturer:"Toyota", 
            model:"Corolla", 
            year:2020, 
            mileage:15000, 
            isAvailable:true, 
            rentalCost:50.0,
            doorCount:4,
            fuelType:0,
            trunkVolume:500.0);
    }

    [Test]
    public void Constructor()
    {
        
        Assert.That(_myCar, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(_myCar.DoorCount, Is.EqualTo(4));
            Assert.That(_myCar.FuelType, Is.EqualTo(EFuelType.Petrol));
            Assert.That(_myCar.TrunkVolume, Is.EqualTo(500.0));
        });
    }
}