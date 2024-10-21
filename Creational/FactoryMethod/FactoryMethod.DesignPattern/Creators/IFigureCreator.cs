using System;
using FactoryMethod.DesignPattern.Figures;

namespace FactoryMethod.DesignPattern.Creators;

public interface IFigureCreator
{
    IFigure CreateFigureWithDefaultMeasures();
}
