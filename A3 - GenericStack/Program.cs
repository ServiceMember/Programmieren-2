namespace A3___GenericStack;

class Program
{
    static void Main(string[] args)
    {
        var myStack = new Stack<string>();
        myStack.Push("Hello");
        myStack.Push("World");
        Console.WriteLine(myStack.Pop());
        Console.WriteLine(myStack.Pop());
        Console.WriteLine(myStack.Pop());
    }
}