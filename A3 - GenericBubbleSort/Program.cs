namespace A3___GenericBubbleSort;

class Program
{
    static void Main(string[] args)
    {
        var array = new Char[] { 'a', 'e', 'd' };
        Sorter<char>.BubbleSort(ref array);
        Console.WriteLine("Sorted array: " + string.Join(", ", array));
    }
}