using System.Runtime.InteropServices.JavaScript;

namespace Fahrzeugverleih;

class Program
{
    static void Main(string[] args)
    {
        var vehicle1 = new Vehicle(model:"X5", manufacturer:"BMW", year:2020, mileage:10000, isAvailable:true, rentalCost:50);
        var vehicle2 = new Vehicle(model:"A4", manufacturer:"Audi", year:2019, mileage:20000, isAvailable:true, rentalCost:40);
        var vehicle3 = new Vehicle(model:"C-Klasse", manufacturer:"Mercedes", year:2021, mileage:5000, isAvailable:true, rentalCost:60);
        var vehicle4 = new Vehicle(model:"Golf", manufacturer:"Volkswagen", year:2018, mileage:30000, isAvailable:true, rentalCost:30);
        var vehicle5 = new Vehicle(model:"3er", manufacturer:"BMW", year:2022, mileage:2000, isAvailable:true, rentalCost:70);
        
        Vehicle[] vehicles =  [ vehicle1, vehicle2, vehicle3, vehicle4, vehicle5 ];

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }
    }
}