namespace CasinoGame
{
    public class Blackjack : IGame
    {
        private Player _player;
        private Random _rand = new();

        public Blackjack(Player player)
        {
            _player = player;
        }

        public string Name => "Blackjack";

        public bool CanPlay() => _player.CanPlay(); 

        public void Play()
        {
            int bet = 10;

            if (!_player.CanPlay())
            {
                Console.WriteLine("🚫 Not enough balance to play Blackjack.");
                return;
            }

            _player.DeductBalance(bet);
            Console.WriteLine($"💸 You bet {bet} kr.");

            List<int> playerHand = new();
            List<int> dealerHand = new();

            playerHand.Add(DrawCard());
            playerHand.Add(DrawCard());
            dealerHand.Add(DrawCard());

            Console.WriteLine($"\n🧍 Your cards: {string.Join(", ", playerHand)} (Total: {HandValue(playerHand)})");
            Console.WriteLine($"🃏 Dealer shows: {dealerHand[0]}");
            
            while (true)
            {
                Console.Write("\n▶ (H)it or (S)tand? ");
                var choice = Console.ReadLine().ToLower();

                if (choice == "h")
                {
                    var card = DrawCard();
                    playerHand.Add(card);
                    Console.WriteLine($"🃍 You drew: {card} (Total: {HandValue(playerHand)})");

                    if (HandValue(playerHand) > 21)
                    {
                        Console.WriteLine("💥 Bust! You lose.");
                        return;
                    }
                }
                else if (choice == "s")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("❌ Invalid input.");
                }
            }
            
            dealerHand.Add(DrawCard());
            while (HandValue(dealerHand) < 17)
            {
                dealerHand.Add(DrawCard());
            }

            Console.WriteLine($"\n🧑‍💼 Dealer's cards: {string.Join(", ", dealerHand)} (Total: {HandValue(dealerHand)})");

            int playerScore = HandValue(playerHand);
            int dealerScore = HandValue(dealerHand);

            if (dealerScore > 21 || playerScore > dealerScore)
            {
                Console.WriteLine("✅ You win! +20 kr");
                _player.AddBalance(20); 
            }
            else if (playerScore == dealerScore)
            {
                Console.WriteLine("🤝 It's a tie. You get your bet back.");
                _player.AddBalance(10);
            }
            else
            {
                Console.WriteLine("❌ Dealer wins.");
            }
        }

        private int DrawCard()
        {
            return _rand.Next(2, 12); // 2–11 (Ess = 11)
        }

        private int HandValue(List<int> hand)
        {
            int total = 0;
            int aces = 0;

            foreach (var card in hand)
            {
                total += card;
                if (card == 11) aces++;
            }

            while (total > 21 && aces > 0)
            {
                total -= 10;
                aces--;
            }

            return total;
        }
    }
}

