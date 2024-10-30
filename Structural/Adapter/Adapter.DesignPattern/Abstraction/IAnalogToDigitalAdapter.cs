namespace Adapter.DesignPattern.Abstraction;

public interface IAnalogToDigitalAdapter
{
    public IList<bool> AnalogToDigital(IList<float> analogValues, float logicalOne);
}