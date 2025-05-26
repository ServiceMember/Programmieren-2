namespace TestFahrzeugverleih;

using Fahrzeugverleih;
using System.Reflection;

[TestFixture]
public class UnitTestTruck
{
    private Truck _myTruck;
    private int _id;

    [SetUp]
    public void Setup()
    {
        
        var fi = typeof(Vehicle)
            .GetField("_id", BindingFlags.NonPublic | BindingFlags.Static);

        _id = (fi.GetValue(null) as int?) ?? 0;
        
        _myTruck = new Truck(
            manufacturer: "Toyota",
            model: "Corolla",
            year: 2020,
            mileage: 15000,
            isAvailable: true,
            rentalCost: 50.0,
            loadCapacity: 1000.0,
            axleCount: 4,
            loadingArea: 50.0,
            rentalCostPerSquareMeter: 10.0);
    }

    [Test]
    public void Constructor()
    {
        Assert.That(_myTruck, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(_myTruck.Id, Is.EqualTo(_id));
            Assert.That(_myTruck.LoadCapacity, Is.EqualTo(1000.0));
            Assert.That(_myTruck.AxleCount, Is.EqualTo(4));
            Assert.That(_myTruck.LoadingArea, Is.EqualTo(50.0));
            Assert.That(_myTruck.RentalCostPerSquareMeter, Is.EqualTo(10.0));
        });
    }

    [Test]
    public void CalculateRentalCost()
    {
        Assert.That(_myTruck.CalculateRentalCost(3), Is.EqualTo(50.0 * 3 + 10.0 * 50.0));
    }
}