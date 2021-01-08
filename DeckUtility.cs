using System;
using System.Collections.Generic;

namespace War
{
    public class DeckUtility
    {
        
        public static List<Card> CreateDeck()
        {
            List<Card> deck = new List<Card>();
            for(int i=0;i<4;i++){
                for(int l=0;l<13;l++){
                    Card card = new Card(i, l + 1);
                    deck.Add(card);
                }
            }
            return deck;

            // This class should create a deck of cards
            // This should use one or more loops to create
            // each card in a standard, 4-suit deck of cards
            // As you create the cards add them to a List of cards


            // Assume a suit of 0 is Spades, 1 is Hearts, 2 is Diammonds, and 3 is Clubs
            // If the card value is 12 and suit is 0 the card is essentially
            // the Queen of Spades. If the value is 1 and the suit is 3 it is
            // the Ace of Clubs.

            // This method should return the list when complete.
          
        }
        public static List<Card> ShuffleDeck(List<Card> old_deck)
        {
            List<Card> new_deck = new List<Card>();
            Random rand = new Random();
            int r;
            while (old_deck.Count > 0)
            {
                r = rand.Next(0, old_deck.Count-1);
                new_deck.Add(old_deck[r]);
                old_deck.RemoveAt(r);
            }
            return new_deck;
        }

        public static Dictionary<string, List<Card>> DivideDeck(List<Card> deck)
        {
            // this method goes through a single list of 52 cards, splits it in
            // two halves and returns a Dictionary with the two bits
            List<Card> first = new List<Card>();
            List<Card> second = new List<Card>();
            Dictionary<string, List<Card>> pair = new Dictionary<string, List<Card>>();

            for (int i = 0; i < 52; i++)
            {
                if(i > 25)
                {
                    first.Add(deck[i]);
                }
                else
                {
                    second.Add(deck[i]);
                }
            }
            pair.Add("first_half", first);
            pair.Add("second_half", second);
            return pair;
        }
    }
}
