namespace CasinoGame;

public class SlotMachine : IGame
{
    public string Name => "Slot Machine";
    private Player _player;
    private Random _rnd = new Random();

    public SlotMachine(Player player)
    {
        _player = player;
    }

    public bool CanPlay() => _player.Balance >= 10;

    public void Play()
    {
        _player.DeductBalance(10);
        
        Console.WriteLine("+-----------+");
        Console.WriteLine("| X | X | X |");
        Console.WriteLine("+-----------+");

        int row = Console.CursorTop - 2;
        
        for (int i = 0; i < 10; i++)
        {
            int n1 = _rnd.Next(1, 10);
            int n2 = _rnd.Next(1, 10);
            int n3 = _rnd.Next(1, 10);

           
            Console.SetCursorPosition(2, row); 
            Console.Write($"{n1} | {n2} | {n3}");

            Thread.Sleep(300);
        }
        
        
        int final1 = _rnd.Next(1, 10);
        int final2 = _rnd.Next(1, 10);
        int final3 = _rnd.Next(1, 10);

        Console.SetCursorPosition(2, Console.CursorTop);
        Console.Write($"{final1} | {final2} | {final3}");

        Console.WriteLine(); 
        
        if (final1 == final2 && final2 == final3)
        {
            Console.WriteLine("\n🎉 Jackpot!");
            _player.AddBalance(100);
        }
        else if (final1 == final2 || final2 == final3)
        {
            Console.WriteLine("\"✅ You won!");
            _player.AddBalance(20);
        }
        else
        {
            Console.WriteLine("\n❌ Too bad!");
        }

        Console.WriteLine($"💰 Balance: {_player.Balance}");
    }
}
