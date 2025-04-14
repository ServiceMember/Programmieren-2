namespace Assignment1;

public class Quersumme
{
    public string Input { get; set; }
    
    public Quersumme(string? input)
    {
        if (input == null)
        {
            Input = "";
        }
        
        if (input != null)
        {
            Input = input;
        }
    }
    
    public int CalculateQuersumme()
    {
        int sum = 0;
        foreach (char c in Input)
        {
            if (char.IsDigit(c))
            {
                sum += c - '0';
            }
        }
        return sum;
    }
    
    public void PrintQuersumme()
    {
        string output = $"{Input[0]}";
        for (int i=1; i<Input.Length; i++)
        {
            output += " + " + Input[i];
        }
        
        Console.WriteLine($"{output} = {CalculateQuersumme()}.");
    }
}