namespace A2___Gehälter;

class Program
{
    static void Main(string[] args)
    {
        var myHourlyEmployee = new HourlyEmployee("Max", "IT", 20, 20);
        var myPermanentEmployee = new PermanentEmployee("Anna", "HR", 3000);
        Console.WriteLine($"Salary of {myHourlyEmployee.Name}: {myHourlyEmployee.CalculateSalary()}");
        Console.WriteLine($"Salary of {myPermanentEmployee.Name}: {myPermanentEmployee.CalculateSalary()}");
        myHourlyEmployee.AddHours(20);
        Console.WriteLine($"New salary of {myHourlyEmployee.Name}: {myHourlyEmployee.CalculateSalary()}");
    }
}