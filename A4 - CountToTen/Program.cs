namespace A4___CountToTen;

class Program
{
    private static IEnumerable<int> numbers = CountToTen();
    
    static void Main(string[] args)
    {
        foreach (var integer in numbers)
        {
            Console.WriteLine(integer);
        }
    }

    private static IEnumerable<int> CountToTen()
    {
        for (int i = 1; i <= 10; i++)
        {
            yield return i;
        }
    }
}