namespace WebApplication1;
public class Triangle
{
    private double firstSide;
    private double secondSide;
    private double thirdSide;
    public bool isCorrect = false;
    public Triangle(double first_side_val, double second_side_val, double third_side_val)
    {
        firstSide = first_side_val;
        secondSide = second_side_val;
        thirdSide = third_side_val;
        isCorrect = Validation();
    }
    public bool Validation()
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            return false;
        if (firstSide >= secondSide + thirdSide || secondSide >= firstSide + thirdSide || thirdSide >= firstSide + secondSide)
            return false;
        return true;
    }
    public double GetArea()
    {
        double semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide));
    }
}
