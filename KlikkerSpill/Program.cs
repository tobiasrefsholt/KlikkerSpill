using System.Data;
using KlikkerSpill;


var game = new Game();
var commands = new CommandSet(game);

while (true)
{
    WriteMenu();
    commands.Run(Console.ReadKey().Key);
}

void WriteMenu()
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