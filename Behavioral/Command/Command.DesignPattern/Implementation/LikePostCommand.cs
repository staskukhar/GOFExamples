using Command.DesignPattern.Abstraction;

namespace Command.DesignPattern.Implementation;

public class LikePostCommand(string trigger) : ICommand
{
    private string Trigger { get; set; } = trigger;
    
    public void Execute()
    {
        Console.WriteLine($"Post liked by: {this.Trigger}.");
    }
}