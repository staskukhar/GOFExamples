using Command.DesignPattern.Abstraction;

namespace Command.DesignPattern.Implementation;

public class PostHandler(ICommand likeCommand)
{
    private ICommand LikeCommand { get; set; } = likeCommand;
    
    public void HandleLikeButtonClick()
    {
        LikeCommand.Execute();
    }
}