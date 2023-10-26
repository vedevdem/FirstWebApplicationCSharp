using Model.Figures;

namespace MyWebApplication;

public class Processor
{
    public double SumArea(IEnumerable<IFigure> figures)
    {
        var sum = 0.0;
        foreach(var figure in figures)
        {
            sum += figure.GetArea();
        }
        return sum;
    }
}
