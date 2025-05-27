namespace A4___CountToTen;

class Program
{
    static void Main(string[] args)
    {
        foreach (var integer in CountToTen())
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