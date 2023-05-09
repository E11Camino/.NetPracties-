namespace DeckOfCards
{
    public class PokerDeck : DeckOfCards
    {
        public PokerDeck()
        {
            Cards = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Card card = new Card
                    {
                        Suit = suit,
                        Rank = rank
                    };
                    Cards.Add(card);
                }
            }
        }
    }
}
