namespace A4___InterfaceSort;

public class SelectionSort <T> : ISorter<T> where T : IComparable<T>
{
    public T[] Sort(T[] array)
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