namespace A3___Geometrien;

class Program
{
    static void Main(string[] args)
    {
        CCircle myCircle = new CCircle(1);
        Console.WriteLine($"Circle Area: {myCircle.Surface}");
        
        CRectangle myRectangle = new CRectangle(4, 5);
        Console.WriteLine($"Rectangle Area: {myRectangle.Surface}");
        
        CSquare mySquare = new CSquare(5);
        Console.WriteLine($"Square Area: {mySquare.Surface}");
        
        List<CShape> shapeList = new List<CShape>();
        shapeList.Add(mySquare);
        shapeList.Add(myCircle);
        shapeList.Add(myRectangle);
        
        shapeList.ForEach(shape => Console.Write($"{shape.Surface} "));
        shapeList.Sort();
        Console.WriteLine();
        shapeList.ForEach(shape => Console.Write($"{shape.Surface} "));
    }
}