namespace A3___Geometrien;

public class CRectangle(double width, double height) : CShape
{
    public double Width { get; set; } = width;
    public double Height { get; set; } = height;

    public override double CalculateArea()
    {
        return Width * Height;
    }
}