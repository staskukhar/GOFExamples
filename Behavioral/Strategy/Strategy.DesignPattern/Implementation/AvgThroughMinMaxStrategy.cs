using Strategy.DesignPattern.Abstraction;

namespace Strategy.DesignPattern.Implementation;

public class AvgThroughMinMaxStrategy : IAvgStrategy
{
    public double ReckonAvg(IList<int> numbers)
    {
        return (numbers.Min() + numbers.Max()) / 2d;
    }
}