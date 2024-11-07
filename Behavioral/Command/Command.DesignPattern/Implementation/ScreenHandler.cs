using Command.DesignPattern.Abstraction;

namespace Command.DesignPattern.Implementation;

public class ScreenHandler(ICommand likeCommand)
{
    private ICommand LikeCommand { get; set; } = likeCommand;

    public void HandlePostDoubleClick()
    {
        LikeCommand.Execute();
    }
}