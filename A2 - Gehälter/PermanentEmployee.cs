namespace A2___Gehälter;

public class PermanentEmployee : Worker
{
    private readonly double _salary;

    public PermanentEmployee(string name, string department, double salary) : base(name, department)
    {
        _salary = salary;
    }
    
    public override double CalculateSalary()
    {
        return _salary;
    }
}