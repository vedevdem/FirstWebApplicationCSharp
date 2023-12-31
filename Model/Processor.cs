﻿using Model.Figures;

namespace MyWebApplication;

public class Processor
{
    public double SumArea(List<IFigure> figures)
    {
        var sum = 0.0;
        foreach(var figure in figures)
        {
            sum += figure.GetArea();
        }
        return sum;
    }
}
