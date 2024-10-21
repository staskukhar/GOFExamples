using System;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace FactoryMethod.DesignPattern.Figures;

public class Circle : IFigure
{
    public double Radius { get; set; }

    public Circle()
    {
        this.Radius = 1.0D;
    }
    public Circle(double radius)
    {
        this.Radius = radius;
    }
    
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(this.Radius, 2);
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}
