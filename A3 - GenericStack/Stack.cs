namespace A3___GenericStack;

public class Stack<T>
{
    private readonly List<T> _list = [];
    
    public void Push(T item)
    {
        _list.Add(item);
    }

    public T Pop()
    {
        if (_list.Count == 0) 
            throw new InvalidOperationException("Stack is empty");
        
        var temp = _list.Last();
        _list.RemoveAt(_list.Count - 1);
        return temp;
    }
    
    public int Count => _list.Count;

    public void Clear()
    {
        _list.Clear();
    }
}