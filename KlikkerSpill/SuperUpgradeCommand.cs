namespace KlikkerSpill;

public class SuperUpgradeCommand : ICommand
{
    private Game _game;
    public ConsoleKey Character { get; } = ConsoleKey.S;

    public SuperUpgradeCommand(Game game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.SuperUpgrade();
    }
}