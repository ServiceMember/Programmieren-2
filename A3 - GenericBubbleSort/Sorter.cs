namespace A3___GenericBubbleSort;

public static class Sorter <T> where T : IComparable<T>
{
    public static T[] BubbleSort(T[] list) 
    {
        bool swapped = true;
        
        while (swapped)
        {
            swapped = false;
            
            for(int i = 0; i < list.Length - 1; i++)
            {
                if (list[i].CompareTo(list[i + 1]) <= 0) continue;
                
                // Swap the elements
                (list[i], list[i + 1]) = (list[i + 1], list[i]);
                swapped = true;
            }
            
        };
        
        return list;
    }
}