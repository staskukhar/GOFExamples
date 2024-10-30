using Adapter.DesignPattern.Abstraction;

namespace Adapter.DesignPattern.Implementation;

public class RandomAnalogSource : IAnalogSource
{
    public IList<float> VoltageValues(int numberOfValues, float min, float max)
    {
        IList<float> values = new List<float>();
        for (int i = 0; i < numberOfValues; i++)
        {
            
            values.Add(Random.Shared.NextSingle() * (max - min) + min);
        }
        
        return values;
    }
}