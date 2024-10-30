namespace Adapter.DesignPattern.Abstraction;

public interface IAnalogSource
{
    public IList<float> VoltageValues(int numberOfValues, float min, float max);
}