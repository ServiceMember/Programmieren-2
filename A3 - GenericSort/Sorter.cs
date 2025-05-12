using System.Numerics;

namespace A3___GenericBubbleSort;

public static class Sorter <T> where T : IComparable<T>
{
    public static T[] BubbleSort(T[] array) 
    {
        bool swapped = true;
        
        while (swapped)
        {
            swapped = false;
            
            for(int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) <= 0) 
                    continue;
                
                // Swap the elements
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
                swapped = true;
            }
            
        };
        
        return array;
    }

    public static T[] SelectionSort(T[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var minIndex = i;
            for (var j = i; j < array.Length; j++)
            {
                if (array[j].CompareTo(array[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }

            (array[i], array[minIndex]) = (array[minIndex], array[i]);
        }

        return array;
    }
}