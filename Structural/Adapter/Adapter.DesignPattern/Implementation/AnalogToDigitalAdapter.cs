using Adapter.DesignPattern.Abstraction;

namespace Adapter.DesignPattern.Implementation;

public class AnalogToDigitalAdapter : IAnalogToDigitalAdapter
{
    public IList<bool> AnalogToDigital(IList<float> analogValues, float logicalOne)
    {
        IList<bool> digitalValues = new List<bool>();
        for (int i = 0; i < analogValues.Count(); i++)
        {
            digitalValues.Add(analogValues[i] >= logicalOne);
        }

        return digitalValues;
    }
}