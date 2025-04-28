namespace A2___Gehälter;

public abstract class Worker
{
    public string Name { get; set; }
    public string Department { get; set; }
    
    public Worker(string name, string department)
    {
        Name = name;
        Department = department;
    }
    
    public abstract double CalculateSalary();
}