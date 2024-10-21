using System;
using FactoryMethod.DesignPattern.Figures;

namespace FactoryMethod.DesignPattern.Creators;

public class CircleCreator : IFigureCreator
{
    public IFigure CreateFigureWithDefaultMeasures()
    {
        return new Circle();
    }
}
