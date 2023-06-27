namespace WebApplication1;
public class Triangle
{
    private int firstSide;
    private int secondSide;
    private int thirdSide;

    public Triangle(int first_side_val, int second_side_val, int third_side_val)
    {
        firstSide = first_side_val;
        secondSide = second_side_val;
        thirdSide = third_side_val;
    }
    public double GetArea()
    {
        double semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide));
    }
}
