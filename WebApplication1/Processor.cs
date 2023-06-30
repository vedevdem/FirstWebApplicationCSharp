namespace WebApplication1;

public class Processor
{
    public double SumArea(List<IFigure> figures)
    {
        double sum = 0;
        foreach(IFigure figure in figures)
        {
            sum += figure.GetArea();
        }
        return sum;
    }
}
