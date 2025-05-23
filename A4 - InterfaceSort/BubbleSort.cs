namespace A4___InterfaceSort;

public class BubbleSort <T> : ISorter<T> where T : IComparable<T>
{
    public T[] Sort(T[] array)
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
}