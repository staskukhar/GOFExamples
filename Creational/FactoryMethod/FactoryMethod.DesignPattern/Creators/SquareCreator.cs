using System;
using FactoryMethod.DesignPattern.Figures;

namespace FactoryMethod.DesignPattern.Creators;

public class SquareCreator : IFigureCreator
{
    public IFigure CreateFigureWithDefaultMeasures()
    {
        return new Square();
    }
}
