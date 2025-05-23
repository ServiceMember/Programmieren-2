using System.Net.Mail;

namespace A3___Geometrien;

public abstract class CShape : IComparable<CShape>
{
    public abstract double CalculateArea();

    public int CompareTo(CShape? other)
    {
        if (other == null) return 1;
        if (this.CalculateArea() > other.CalculateArea()) return 1;
        if (this.CalculateArea() < other.CalculateArea()) return -1;
        return 0;
    }
}