using Adapter.DesignPattern.Abstraction;

namespace Adapter.DesignPattern.Implementation;

public class DigitalLed : IDigitalElement
{
    public void HandleSingleValue(bool digitalValue)
    {
        Console.WriteLine(digitalValue ? "Light on" : "Light off");
    }
}