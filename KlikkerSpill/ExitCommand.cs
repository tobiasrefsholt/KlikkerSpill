namespace KlikkerSpill;

public class ExitCommand : ICommand
{
    public ConsoleKey Character { get; } = ConsoleKey.X;

    public void Run()
    {
        Environment.Exit(0);
    }
}