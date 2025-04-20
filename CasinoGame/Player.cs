namespace CasinoGame;

public class Player
{
    public string Name;
    public int Balance { get; private set; }

    public Player(string name, int startingBalance)
    {
        Name = name;
        Balance = startingBalance;
    }
    
    public bool CanPlay() => Balance >= 10;
    public void AddBalance(int amount) => Balance += amount;
    public void DeductBalance(int amount) => Balance -= amount;
}