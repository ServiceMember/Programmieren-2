namespace A3___Geometrien;

public class CCircle(double radius) : CShape
{
    public double Radius{ get; set; } = radius;

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}