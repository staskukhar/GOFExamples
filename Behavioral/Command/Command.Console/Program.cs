using Command.DesignPattern.Implementation;

PostHandler postHandler = new PostHandler(
    new LikePostCommand("button click"));
    
ScreenHandler screenHandler = new ScreenHandler(
    new LikePostCommand("double click"));
    
postHandler.HandleLikeButtonClick();
screenHandler.HandlePostDoubleClick();