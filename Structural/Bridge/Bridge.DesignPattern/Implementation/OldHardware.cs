using Bridge.DesignPattern.Abstraction;

namespace Bridge.DesignPattern.Implementation;

public class OldHardware : IHardware
{
    public void PowerOn()
    {
        Console.WriteLine("Turning power on...");
        Thread.Sleep(3000);
    }

    public void PowerOff()
    {
        Console.WriteLine("Turning power off...");
        Thread.Sleep(3000);
    }

    public void ExecuteComputation(string command)
    {
        Console.WriteLine($"Executing on old hardware: {command}...");
        Thread.Sleep(2000);
    }
}