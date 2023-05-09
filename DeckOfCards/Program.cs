namespace DeckOfCards
{
    internal class Program
    {
        static Random Rand = new Random();

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            PokerDeck deck = new PokerDeck();

            while (true)
            {
                Console.Clear();
                List<Card> cards = Shuffle(deck).Cards.Take(5).ToList();
                Console.WriteLine(cards[0] > cards[1]);
                Console.CursorTop = 15;
                Console.CursorLeft = Console.WindowWidth / 2 - 15;

                foreach (Card card in cards)
                {
                    ConsoleColor color = Console.ForegroundColor;
                    Console.ForegroundColor = GetConsoleColorForCard(card);
                    Console.Write(card + "   ");
                    Console.ForegroundColor = color;
                }
                Console.ReadKey();
            }
            Console.WriteLine("\r\n\r\n");
            Console.ReadKey();
        }

        private static ConsoleColor GetConsoleColorForCard(Card card)
        {
            if (card.Suit == Suit.Spade)
            {
                return ConsoleColor.DarkMagenta;
            }
            if (card.Suit == Suit.Club)
            {
                return ConsoleColor.DarkGray;
            }
            if (card.Suit == Suit.Diamond)
            {
                return ConsoleColor.Blue;
            }
            if (card.Suit == Suit.Heart)
            {
                return ConsoleColor.Red;
            }
            return default;
        }

        static DeckOfCards Shuffle(DeckOfCards deck)
        {
            for (int i = 0; i < deck.Cards.Count; i++)
            {
                Card temp = deck.Cards[i];
                int randomIndex = Rand.Next(i, deck.Cards.Count);
                deck.Cards[i] = deck.Cards[randomIndex];
                deck.Cards[randomIndex] = temp;
            }
            return deck;
        }
    }
}