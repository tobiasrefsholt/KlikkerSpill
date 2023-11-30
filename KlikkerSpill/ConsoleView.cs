namespace KlikkerSpill;

public class ConsoleView
{
    public static void WriteMenu(Game game)
    {
        Console.Clear();
        Console.WriteLine("Kommandoer:");
        Console.WriteLine("- SPACE = klikk(og få poeng)\\r\\n");
        Console.WriteLine("- K = kjøp oppgradering øker poeng per klikk koster 10 poeng");
        Console.WriteLine("- S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng");
        Console.WriteLine("- X = avslutt applikasjonen");
    
        Console.WriteLine($"Du har {game.Points} poeng.");
        Console.WriteLine("Trykk tast for ønsket kommando.");
    }

    public static void HandleInput(Game game)
    {
        var command = Console.ReadKey().Key;
        switch (command)
        {
            case ConsoleKey.Spacebar:
                game.Click();
                break;
            case ConsoleKey.K:
                game.Upgrade();
                break;
            case ConsoleKey.S:
                game.SuperUpgrade();
                break;
            case ConsoleKey.X:
                Environment.Exit(0);
                break;
        }
    }
}