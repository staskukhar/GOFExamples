using Bridge.DesignPattern.Abstraction;

namespace Bridge.DesignPattern.Implementation;

public class WindowsSystem(IHardware hardware) : ISystem
{
    private IHardware Hardware { get; set; } = hardware;
    
    public void Start()
    {
        Console.WriteLine("Starting Windows System...");
        this.Hardware.PowerOn();
    }

    public void Shutdown()
    {
        Console.WriteLine("Shutting down Windows System...");
        this.Hardware.PowerOff();
    }

    public void ExecuteCommand(string command)
    {
        Console.WriteLine($"Windows executes command: {command}");
        this.Hardware.ExecuteComputation(command);
    }
}