namespace Assignment1;

public class NumberGuessingGame
{
    private readonly int _numberToGuess;

    public NumberGuessingGame()
    {
        var random = new Random();
        _numberToGuess = random.Next(2, 100);
    }

    public void Run()
    {
        var guess = -1;
        var attempts = 0;
        Console.WriteLine("Willkommen zum Zahlenraten-Spiel!");
        Console.WriteLine("Ich habe eine Zahl zwischen 1 und 100 gewählt. Versuche sie zu erraten!");
        while (guess != _numberToGuess)
        {
            Console.Write("Gib deine Schätzung ein: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out guess))
            {
                attempts++;
                if (guess < _numberToGuess)
                {
                    Console.WriteLine("Zu niedrig! Versuch es nochmal.");
                }
                else if (guess > _numberToGuess)
                {
                    Console.WriteLine("Zu hoch! Versuch es nochmal.");
                }
                else
                {
                    Console.WriteLine($"Herzlichen Glückwunsch! Du hast die Zahl {_numberToGuess} in {attempts} Versuchen erraten.");
                }
            }
            else
            {
                Console.WriteLine("Bitte gib eine gültige Zahl ein.");
            }
        }
    }   
}