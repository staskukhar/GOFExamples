using System;
using System.Text.Json;

namespace FactoryMethod.DesignPattern.Figures;

public class Square : IFigure
{
    public double Side { get; set; }

    public Square()
    {
        this.Side = 1.0D;
    }

    public Square(double side)
    {
        this.Side = side;
    }

    public double CalculateArea()
    {
        return Math.Pow(this.Side, 0);
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}
