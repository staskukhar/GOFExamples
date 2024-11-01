using Composite.DesignPattern.Abstraction;

namespace Composite.DesignPattern.Implementation;

public class CyberTree : IFruitAnalyzer
{
    private IList<IFruitAnalyzer> NestedComponents { get; init; } = new List<IFruitAnalyzer>();

    public void AddNestedComponent(IFruitAnalyzer component)
    {
        this.NestedComponents.Add(component);
    }
    
    public int GetNumberOfFruits()
    {
        return NestedComponents.Sum(c => c.GetNumberOfFruits());
    }
}