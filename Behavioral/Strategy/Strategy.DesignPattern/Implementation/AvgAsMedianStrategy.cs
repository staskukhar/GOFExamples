using Strategy.DesignPattern.Abstraction;

namespace Strategy.DesignPattern.Implementation;

public class AvgAsMedianStrategy : IAvgStrategy
{
    public double ReckonAvg(IList<int> numbers)
    {
        if (numbers.Count() % 2 != 0)
        {
            return numbers.ElementAt((int)Math.Floor(numbers.Count() / 2d));
        }
        
        return (numbers.ElementAt(numbers.Count() / 2 - 1) + 
                numbers.ElementAt((numbers.Count() / 2))) / 2d;
    }
}