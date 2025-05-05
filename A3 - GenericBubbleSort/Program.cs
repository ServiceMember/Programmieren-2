namespace A3___GenericBubbleSort;

class Program
{
    static void Main(string[] args)
    {
        var array = new Char[] { 'a', 'e', 'd', 'b', 'c' };
        Sorter<char>.BubbleSort(ref array);
        Console.WriteLine("Sorted array: " + string.Join(", ", array));
        
        var intArray = new int[] { 3, 1, 4, 1, 5, 9 };
        Sorter<int>.BubbleSort(ref intArray);
        Console.WriteLine("Sorted int array: " + string.Join(", ", intArray));
    }
}