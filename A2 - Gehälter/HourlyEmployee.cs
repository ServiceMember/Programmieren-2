namespace A2___Gehälter;

public class HourlyEmployee : Worker
{
    private double _hoursWorked;
    private readonly double _hourlySalary;

    public HourlyEmployee(string name, string department, double hourlySalary, double hoursWorked) : base(name, department)
    {
        _hourlySalary = hourlySalary;
        _hoursWorked = hoursWorked;
    }
    
    public override double CalculateSalary()
    {
        return _hourlySalary*_hoursWorked;
    }

    public void AddHours(double hoursWorked)
    {
        _hoursWorked += hoursWorked;
    }
}