namespace KlikkerSpill;

public class CommandSet
{
    private ICommand[] _commands;

    public CommandSet(Game game)
    {
        _commands = new ICommand[]
        {
            new ClickCommand(game),
            new UpgradeCommand(game),
            new SuperUpgradeCommand(game),
            new ExitCommand()
        };
    }

    public void Run(ConsoleKey commandKey)
    {
        var command = FindCommand(commandKey);
        command?.Run();
    }

    private ICommand? FindCommand(ConsoleKey commandKey)
    {
        return _commands.FirstOrDefault(command => command.Character == commandKey);
    }
}