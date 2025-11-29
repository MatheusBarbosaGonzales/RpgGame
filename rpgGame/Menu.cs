namespace rpgGame;

public class Menu
{
    static string[] a = {"Teste","Teste","Teste","Sair"};
    
    public static void menuController(int menuValue)
    {
        var test = Console.ReadKey();
        string input = test.Key.ToString().ToLower();
        switch(input)
        {
            case "a":
            
                break;
            case "s":
                Globals.menuValue++;
                break;
            case "d":
            
                break;
            case "w":
                Globals.menuValue--;
                break;
            case "spacebar":
                menuAction(Globals.menuValue);
                break;  
        }
    }

    public static void writeMenuOptions(int input)
    {
        Console.WriteLine("Bem vindo, não sei o que não sei o que lá\n");
        for (int i = 0; i < a.Length; i++)
        {
            if (i == input)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"> {a[i]}");    
                Console.ResetColor();
                continue;
            }

            Console.WriteLine(a[i]);
        }
    }

    public static void menuAction(int menuValue)
    {
        switch (menuValue)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                writeMenuOptions(menuValue);
                break;
            case 3:
                Globals.gameRunning = false;
                break;   
            
        }
    }
}