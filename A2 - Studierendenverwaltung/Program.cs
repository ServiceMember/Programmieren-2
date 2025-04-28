namespace A2___Studierendenverwaltung;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var student1 = new Student(123456, "Max Mustermann", 20);
        student1.AddGrade(2);
        student1.AddGrade(1);
        Console.WriteLine(student1);
    }
}