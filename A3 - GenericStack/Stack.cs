namespace A3___GenericStack;

public class Stack<T>
where T : class
{
    private readonly List<T> _stack = [];
    
    public void Push(T item)
    {
        _stack.Add(item);
    }

    public T Pop()
    {
        if (_stack.Count == 0) 
            throw new InvalidOperationException("Stack is empty");
        
        var temp = _stack.Last();
        _stack.RemoveAt(_stack.Count - 1);
        return temp;
    }
    
}