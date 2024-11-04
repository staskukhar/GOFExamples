using Bridge.DesignPattern.Abstraction;

namespace Bridge.DesignPattern.Implementation;

public class NewHardware : IHardware
{
    public void PowerOn()
    {
        Console.WriteLine("Turning power on...");
        Thread.Sleep(500);
    }

    public void PowerOff()
    {
        Console.WriteLine("Turning power off...");
        Thread.Sleep(500);
    }

    public void ExecuteComputation(string command)
    {
        Console.WriteLine($"Executing on new hardware: {command}...");
        Thread.Sleep(200);
    }
}