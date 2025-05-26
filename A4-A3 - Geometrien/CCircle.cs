namespace A3___Geometrien;

public class CCircle(double radius) : CShape
{
    private double Radius{ get; set; } = radius;

    protected override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}