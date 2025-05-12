namespace A3___GenericBubbleSort;

class Program
{
    static void Main(string[] args)
    {
        char[] array = [ 'a', 'e', 'd', 'b', 'c' ];
        array = Sorter<char>.BubbleSort(array);
        Console.WriteLine("Sorted array: " + string.Join(", ", array));
        
        int[] intArray = [ 3, 1, 4, 1, 5, 9 ];
        intArray = Sorter<int>.SelectionSort(intArray);
        Console.WriteLine("Sorted int array: " + string.Join(", ", intArray));
    }
}