namespace WebApplication1;
public class Triangle
{
    public int a;
    public int b;
    public int c;

    public Triangle(int a_, int b_, int c_)
    {
        a = a_;
        b = b_;
        c = c_;
    }
    public double GetArea()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}
