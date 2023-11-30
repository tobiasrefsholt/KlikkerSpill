namespace KlikkerSpill;

public class ClickCommand : ICommand
{
    private Game _game;
    public ConsoleKey Character { get; } = ConsoleKey.Spacebar;

    public ClickCommand(Game game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.Click();
    }
}