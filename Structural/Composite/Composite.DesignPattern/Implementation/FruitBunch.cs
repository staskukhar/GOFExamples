using System.Security.AccessControl;
using Composite.DesignPattern.Abstraction;

namespace Composite.DesignPattern.Implementation;

public class FruitBunch(int numberOfFruits) : IFruitAnalyzer
{
    private int NumberOfFruits { get; init; } = numberOfFruits;
    
    public int GetNumberOfFruits()
    {
        return this.NumberOfFruits;
    }
}