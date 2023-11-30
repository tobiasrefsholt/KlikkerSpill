namespace KlikkerSpill;

public interface ICommand
{
    void Run();
    ConsoleKey Character { get; }
}