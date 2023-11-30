namespace KlikkerSpill;

public class UpgradeCommand : ICommand
{
    private Game _game;
    public ConsoleKey Character { get; } = ConsoleKey.K;

    public UpgradeCommand(Game game)
    {
        _game = game;
    }
    
    public void Run()
    {
        _game.Upgrade();
    }
}