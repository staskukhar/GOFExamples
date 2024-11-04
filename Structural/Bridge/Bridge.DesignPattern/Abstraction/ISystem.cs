namespace Bridge.DesignPattern.Abstraction;

public interface ISystem
{
    public void Start();
    
    public void Shutdown();
    
    public void ExecuteCommand(string command);
}