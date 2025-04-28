namespace A2___Tiere;

public class Cat : Animal
{
    public string FurColor{ get; set; }
    public string FavoritePerson { get; set; }
    
    
    public Cat(string name, int age, string furColor, string favoritePerson) : base(name, age)
    {
        FurColor = furColor;
        FavoritePerson = favoritePerson;
    }
    
    public override void makeSound()
    {
        Console.WriteLine("Meow");
    }
    
    public bool PlaysWith(string person)
    {
        return person == FavoritePerson;
    }
}