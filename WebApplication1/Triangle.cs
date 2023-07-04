namespace WebApplication1;
public class Triangle : IFigure
{
    private readonly double _minimalSide;
    private readonly double _mediumSide;
    private readonly double _maximumSide;
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        double[] sidesArray = { firstSide, secondSide, thirdSide };
        Array.Sort(sidesArray);
        _minimalSide = sidesArray[0];
        _mediumSide = sidesArray[1];
        _maximumSide = sidesArray[2];
        Validate();
    }
    private void Validate()
    {
        ValidationHelper.ThrowsIfNotPositive(_minimalSide);
        ValidationHelper.ThrowsIfNotPositive(_mediumSide);
        ValidationHelper.ThrowsIfNotPositive(_maximumSide);
        TriangleInequalityCheckForAllSides();
    }
    private void TriangleInequalityCheckForAllSides()
    {
        TriangleInequalityCheckForSpecificSide(_minimalSide, _mediumSide, _maximumSide);
        TriangleInequalityCheckForSpecificSide(_mediumSide, _minimalSide, _maximumSide);
        TriangleInequalityCheckForSpecificSide(_maximumSide, _mediumSide, _minimalSide);
    }
    private void TriangleInequalityCheckForSpecificSide(double testSide, double leftSide, double rightSide)
    {
        if (testSide >= leftSide + rightSide)
            throw new ArgumentOutOfRangeException(nameof(testSide), "side value is too big (the triangle inequality is not satisfied)");
    }
    public double GetMinSide()
    {
        return _minimalSide;
    }
    public double GetMidSide()
    {
        return _mediumSide;
    }
    public double GetMaxSide()
    {
        return _maximumSide;
    }
    public double GetArea()
    {
        double semiPerimeter = (_minimalSide + _mediumSide + _maximumSide) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _minimalSide) * (semiPerimeter - _mediumSide) * (semiPerimeter - _maximumSide));
    }
    public bool IsRectangular()
    {
        if (_maximumSide * _maximumSide == _mediumSide * _mediumSide + _minimalSide * _minimalSide)
            return true;
        return false;
    }
}
