using System.Reflection.Metadata.Ecma335;
using Strategy.DesignPattern.Abstraction;

namespace Strategy.DesignPattern.Implementation;

public class AvgComputer(IAvgStrategy strategy)
{
    public IAvgStrategy Strategy { get; set; } = strategy;

    public double GetAvg(IList<int> numbers)
    {
        return this.Strategy.ReckonAvg(numbers);
    }
}