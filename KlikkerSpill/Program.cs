using System.Data;
using KlikkerSpill;


var game = new Game();

while (true)
{
    ConsoleView.WriteMenu(game);
    ConsoleView.HandleInput(game);
}