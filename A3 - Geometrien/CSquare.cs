namespace A3___Geometrien;

public class CSquare(double height) : CShape
{
    public double Height { get; set; } = height;

    public override double CalculateArea()
    {
        return Height * Height;
    }
}