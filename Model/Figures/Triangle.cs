using MyWebApplication;

namespace Model.Figures;
public class Triangle : IFigure
{
    private readonly double _firstSide;
    private readonly double _secondSide;
    private readonly double _thirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
        Validate();
    }

    private void Validate()
    {
        ValidationHelper.ThrowsIfNotPositive(_firstSide);
        ValidationHelper.ThrowsIfNotPositive(_secondSide);
        ValidationHelper.ThrowsIfNotPositive(_thirdSide);
        TriangleInequalityCheckForAllSides();
    }

    private void TriangleInequalityCheckForAllSides()
    {
        TriangleInequalityCheckForSpecificSide(_firstSide, _secondSide, _thirdSide);
        TriangleInequalityCheckForSpecificSide(_secondSide, _firstSide, _thirdSide);
        TriangleInequalityCheckForSpecificSide(_thirdSide, _secondSide, _firstSide);
    }

    private void TriangleInequalityCheckForSpecificSide(double testSide, double leftSide, double rightSide)
    {
        if (testSide >= leftSide + rightSide)
            throw new ArgumentOutOfRangeException(nameof(testSide), "side value is too big (the triangle inequality is not satisfied)");
    }

    public double GetArea()
    {
        double semiPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _firstSide) * (semiPerimeter - _secondSide) * (semiPerimeter - _thirdSide));
    }

    public bool IsRectangular()
    {
        double[] sidesArray = { _firstSide, _secondSide, _thirdSide };
        Array.Sort(sidesArray);
        if (sidesArray[2] * sidesArray[2] == sidesArray[1] * sidesArray[1] + sidesArray[0] * sidesArray[0])
            return true;
        return false;
    }
}
