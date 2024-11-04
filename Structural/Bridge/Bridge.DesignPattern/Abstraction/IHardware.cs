namespace Bridge.DesignPattern.Abstraction;

public interface IHardware
{
    public void PowerOn();
    
    public void PowerOff();

    public void ExecuteComputation(string command);
}