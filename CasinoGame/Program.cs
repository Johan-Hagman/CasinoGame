using CasinoGame;

Console.WriteLine("🎰 Welcome to the Casino!");
Console.Write("Enter your name: ");
var name = Console.ReadLine();
var player = new Player(name, 50);

while (true)
{
    Console.Clear();
    Console.WriteLine($"👋 Hello, {player.Name}!");
    Console.WriteLine($"💰 Balance: {player.Balance} kr\n");
    
    List<IGame> games = new List<IGame>
    {
        new SlotMachine(player),
        new Blackjack(player)
        // Här kan du lägga till fler spel!
    };

   
    Console.WriteLine("🎮 Choose a game:");
    for (int i = 0; i < games.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {games[i].Name}");
    }
    Console.WriteLine("Q. Quit");

    Console.Write("\nYour choice: ");
    string input = Console.ReadLine().ToLower();

    if (input == "q")
    {
        Console.WriteLine("👋 Thanks for visiting the casino!");
        break;
    }

    if (int.TryParse(input, out int choice) && choice >= 1 && choice <= games.Count)
    {
        IGame selectedGame = games[choice - 1];
        Console.Clear();
        Console.WriteLine($"🎲 You selected: {selectedGame.Name}!\n");

        while (selectedGame.CanPlay())
        {
            Console.WriteLine("▶ Press [Enter] to play a round");
            Console.WriteLine("⬅ Press [M] to return to the main menu");
            Console.WriteLine("❌ Press [Q] to quit the casino\n");

            var key = Console.ReadKey(true);
            char gameInput = char.ToLower(key.KeyChar);

            if (gameInput == 'q')
            {
                Console.WriteLine("\n👋 Thanks for playing!");
                return;
            }
            if (gameInput == 'm')
            {
                break; 
            }
            if (key.Key == ConsoleKey.Enter)
            {
                selectedGame.Play();
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey(true);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        if (!selectedGame.CanPlay())
        {
            Console.WriteLine("💸 You don't have enough balance to continue.");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey(true);
        }
    }
    else
    {
        Console.WriteLine("❌ Invalid selection.");
        Console.WriteLine("Press any key to try again...");
        Console.ReadKey(true);
    }
}




