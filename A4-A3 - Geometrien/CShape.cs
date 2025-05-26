using System.Net.Mail;

namespace A3___Geometrien;

public abstract class CShape : IComparable<CShape>
{
    protected abstract double CalculateArea();

    public int CompareTo(CShape? other)
    {
        if (other == null) return 1;
        if (Surface > other.Surface) return 1;
        if (this.Surface < other.Surface) return -1;
        return 0;
    }
    
    public double Surface => CalculateArea();
}