using Strategy.DesignPattern.Abstraction;

namespace Strategy.DesignPattern.Implementation;

public class AvgThroughAllStrategy : IAvgStrategy
{
    public double ReckonAvg(IList<int> numbers)
    {
        return numbers.Average();
    }
}