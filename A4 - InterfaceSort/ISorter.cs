namespace A4___InterfaceSort;

public interface ISorter<T> where T : IComparable<T>
{
    T[] Sort(T[] array);
}