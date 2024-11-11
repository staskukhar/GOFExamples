using Strategy.DesignPattern.Abstraction;
using Strategy.DesignPattern.Implementation;

IList<int> numbers = [2, 4, 5, 6];
AvgComputer computer = new AvgComputer(new AvgThroughMinMaxStrategy());

Console.WriteLine($"Avg through min/max strategy: {computer.GetAvg(numbers)}");
computer.Strategy = new AvgThroughAllStrategy();
Console.WriteLine($"Avg through all strategy: {computer.GetAvg(numbers)}");
computer.Strategy = new AvgAsMedianStrategy();
Console.WriteLine($"Avg as median strategy: {computer.GetAvg(numbers)}");