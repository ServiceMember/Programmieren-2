namespace A3___Geometrien;

class Program
{
    static void Main(string[] args)
    {
        CCircle myCircle = new CCircle(1);
        Console.WriteLine($"Circle Area: {myCircle.CalculateArea()}");
        
        CRectangle myRectangle = new CRectangle(4, 5);
        Console.WriteLine($"Rectangle Area: {myRectangle.CalculateArea()}");
        
        CSquare mySquare = new CSquare(5);
        Console.WriteLine($"Square Area: {mySquare.CalculateArea()}");
        
        List<CShape> shapeList = new List<CShape>();
        shapeList.Add(mySquare);
        shapeList.Add(myCircle);
        shapeList.Add(myRectangle);
        
        shapeList.ForEach(shape => Console.Write($"{shape.CalculateArea()} "));
        shapeList.Sort();
        Console.WriteLine();
        shapeList.ForEach(shape => Console.Write($"{shape.CalculateArea()} "));
    }
}