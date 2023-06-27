namespace WebApplication1;

public class Circle
{
    private readonly double _radius;
    public Circle(double radius)
    {
        _radius = radius;
        ValidationHelper.ThrowsIfNotPositive(_radius);
    }
    public double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}
