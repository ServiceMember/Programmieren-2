namespace A4___InterfaceSort;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = [ 5, 3, 8, 1, 4 ];
        ISorter<int> sorter = new BubbleSort<int>();
        Console.WriteLine("Sorted array: " + string.Join(", ", sorter.Sort(numbers)));
        sorter = new SelectionSort<int>();
        Console.WriteLine("Sorted array: " + string.Join(", ", sorter.Sort(numbers)));
    }
}