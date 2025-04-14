namespace Assignment1;

class Program
{
    static void Main(string[] args)
    {
        //Palindrom
        // Console.WriteLine("Teste ob dein Wort ein Palindrom ist:");
        // var palindromCandidate = Console.ReadLine();
        // if (palindromCandidate == null) return;
        // var palindrom = new Palindrom(palindromCandidate);
        // palindrom.PrintPalindrom();
        
        //Quersumme
        // Console.WriteLine("Berechne die Quersumme:");
        // var quersummeInput = Console.ReadLine();
        // if (quersummeInput == null) return;
        // var quersumme = new Quersumme(quersummeInput);
        // quersumme.PrintQuersumme();
        
        //FizzBuzz
        //new FizzBuzz();
        
        //Vowel
        // var myVowel = new VowelCounter();
        // var input = Console.ReadLine();
        // Console.WriteLine(myVowel.CountVowels(input));
        
        //Temperatur
        // Console.Write("Temparatur Format (C/F): ");
        // var format = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        // Console.Write("Temperatur: ");
        // var temperatureValue = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        // Console.WriteLine(TemperatureConverter.ConvertTemperature(temperatureValue, format) + "°" + (format == 'C' ? "F" : "C"));
        
        //Number Guesser
        var game = new NumberGuessingGame();
        game.Run();
    }


}