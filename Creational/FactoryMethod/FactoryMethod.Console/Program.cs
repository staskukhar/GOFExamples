using FactoryMethod.DesignPattern.Creators;
using FactoryMethod.DesignPattern.Figures;

void ProcessFigureCreator(IFigureCreator creator)
{
    IFigure figure = creator.CreateFigureWithDefaultMeasures();
    Console.WriteLine($"Figure: {figure}");
    Console.WriteLine($"Area: {figure.CalculateArea():N2}");
}

ProcessFigureCreator(new SquareCreator());
ProcessFigureCreator(new CircleCreator());