using System.Diagnostics.Metrics;

namespace A4___Exceptions;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bitte gib zwei ganze Zahlen ein:");
        Console.Write("Erste Zahl: ");;
        var eins = Console.ReadLine();
        Console.Write("\n Zweite Zahl: ");
        var zwei = Console.ReadLine();

        try
        {
            var result = (int.Parse(eins) / int.Parse(zwei));
            Console.WriteLine($"Das Ergebnis ist: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Bitte gib eine ganze Zahl ein.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Die Division durch 0 ist nicht erlaubt.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ein unerwarteter Fehler ist aufgetreten: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}