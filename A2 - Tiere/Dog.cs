namespace A2___Tiere;

public class Dog(string name, int age, string owner, string breed)
    : Animal(name, age)
{
    public string Owner { get; set; } = owner;
    public string Breed { get; set; } = breed;

    public override void makeSound()
    {
        Console.WriteLine("Woof");
    }
    
    public string GetDogInfo()
    {
        return $"Name: {Name}, Age: {Age}, Owner: {Owner}, Breed: {Breed}";
    }
}