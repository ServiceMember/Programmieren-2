namespace A2___Studierendenverwaltung;

public class Student
{
    public int StudentNumber { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int[] Grades { get; set; } = [];
    
    public Student(int studentNumber, string name, int age, int[] grades)
    {
        StudentNumber = studentNumber;
        Name = name;
        Age = age;
        Grades = grades;
    }
    public Student(int studentNumber, string name, int age)
    {
        StudentNumber = studentNumber;
        Name = name;
        Age = age;
    }
    
    public void AddGrade(int grade)
    {
        var temp = Grades;
        Grades = new int[temp.Length + 1];
        for(var i = 0; i < temp.Length; i++)
        {
            Grades[i] = temp[i];
        }
        Grades[^1] = grade;
    }

    public override string ToString()
    {
        return $"Matrikelnummer: {StudentNumber}; Name: {Name}; Alter: {Age}; Noten: {string.Join(", ", Grades)}";
    }
}