namespace A3___Geometrien;

public class CRectangle(double width, double height) : CShape
{
    private double Width { get; set; } = width;
    private double Height { get; set; } = height;

    protected override double CalculateArea()
    {
        return Width * Height;
    }
}