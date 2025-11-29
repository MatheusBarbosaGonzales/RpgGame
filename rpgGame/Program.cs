using rpgGame;

while (Globals.gameRunning)
{ 
    Menu.writeMenuOptions(Globals.menuValue);
    Menu.menuController(Globals.menuValue);
    Console.Clear();
}


