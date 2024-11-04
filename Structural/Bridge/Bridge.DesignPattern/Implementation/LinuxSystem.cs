using Bridge.DesignPattern.Abstraction;

namespace Bridge.DesignPattern.Implementation;

public class LinuxSystem(IHardware hardware): ISystem
{
    private IHardware Hardware { get; set; } = hardware;
    
    public void Start()
    {
        Console.WriteLine("Starting Linux System...");
        this.Hardware.PowerOn();
    }

    public void Shutdown()
    {
        Console.WriteLine("Shutting down Linux System...");
        this.Hardware.PowerOff();
    }

    public void ExecuteCommand(string command)
    {
        Console.WriteLine($"Linux executes command: {command}");
        this.Hardware.ExecuteComputation(command);
    }
}