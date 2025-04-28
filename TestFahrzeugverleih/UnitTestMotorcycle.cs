namespace TestFahrzeugverleih;
using Fahrzeugverleih;

[TestFixture]
public class UnitTestMotorcycle
{
    private Motorcycle _myMotorcycle;
    [SetUp]
    public void Setup()
    {
        _myMotorcycle = new Motorcycle(
            manufacturer:"Toyota", 
            model:"Corolla", 
            year:2020, 
            mileage:15000, 
            isAvailable:true, 
            rentalCost:50.0,
            wheelCount:2,
            engineDisplacement:750.0,
            type:"Sport" // e.g., Cruiser, Sport, Touring
        );
    }

    [Test]
    public void Constructor()
    {
        
        Assert.That(_myMotorcycle, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(_myMotorcycle.WheelCount, Is.EqualTo(2));
            Assert.That(_myMotorcycle.EngineDisplacement, Is.EqualTo(750));
            Assert.That(_myMotorcycle.Type, Is.EqualTo("Sport"));
        });
    }
}