using System;

namespace DeckOfCards
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public override string ToString()
        {
            char suit = Suit.ToString().ToLower()[0];
            
            return Rank > Rank.Nine
                ? $"{Rank.ToString()[0]}{suit}"
                : $"{(int)Rank}{suit}";
        }

        public static bool operator > (Card a, Card b)
        {
            return a.Rank > b.Rank;
        }

        public static bool operator < (Card a, Card b)
        {
            return a.Rank < b.Rank;
        }
    }
}
