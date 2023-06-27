namespace WebApplication1;
public class Triangle
{
    private readonly double _firstSide;
    private readonly double _secondSide;
    private readonly double _thirdSide;
    public bool isCorrect = false;
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
        Validate();
    }
    private void Validate()
    {
        if (_firstSide <= 0)
            throw new ArgumentOutOfRangeException("firstSide", "first side value is negative or 0");
        if (_secondSide <= 0)
            throw new ArgumentOutOfRangeException("secondSide", "second side value is negative or 0");
        if (_thirdSide <= 0)
            throw new ArgumentOutOfRangeException("thirdSide", "third side value is negative or 0");
        TriangleInequalityCheck();
    }
    private void TriangleInequalityCheck()
    {
        if (_firstSide  >= _secondSide + _thirdSide)
            throw new ArgumentOutOfRangeException("firstSide", "first side value is too big (the triangle inequality is not satisfied)");
        if (_secondSide >= _firstSide  + _thirdSide)
            throw new ArgumentOutOfRangeException("secondSide", "second side value is too big (the triangle inequality is not satisfied)");
        if (_thirdSide  >= _firstSide  + _secondSide)
            throw new ArgumentOutOfRangeException("thirdSide", "third side value is too big (the triangle inequality is not satisfied)");
    }
    public double GetArea()
    {
        double semiPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _firstSide) * (semiPerimeter - _secondSide) * (semiPerimeter - _thirdSide));
    }
}
