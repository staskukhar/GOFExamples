using Adapter.DesignPattern.Abstraction;
using Adapter.DesignPattern.Implementation;

IAnalogSource source = new RandomAnalogSource();
IAnalogToDigitalAdapter adapter = new AnalogToDigitalAdapter();
IDigitalElement led = new DigitalLed();

IList<float> analogValues = source.VoltageValues(5, 0f, 3f).ToList();
IEnumerable<bool> digitalValues = adapter.AnalogToDigital(analogValues, 1.3f);

for (int i = 0; i < analogValues.Count(); i++)
{
    Console.Write($"{analogValues[i]:N1}V ");
    led.HandleSingleValue(digitalValues.ElementAt(i));
    Thread.Sleep(200);
}