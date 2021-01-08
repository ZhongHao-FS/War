using System;
using System.Collections.Generic;

namespace War
{
    public class WarApp
    {
        private List<Player> players = new List<Player>();

        public WarApp()
        {
            List<Card> deck = DeckUtility.CreateDeck();

            Console.WriteLine("Welcome to War!");
            string input;
            int temp;
            do
            {
                Console.WriteLine("Who is player 1?");
                input = Console.ReadLine();
            } while (string.IsNullOrEmpty(input) || int.TryParse(input,out temp));
            
            Player p1 = new Player(input);

            do
            {
                Console.WriteLine("Who is player 2?");
                input = Console.ReadLine();
            } while (string.IsNullOrEmpty(input) || int.TryParse(input, out temp));
            Player p2 = new Player(input);

            players.Add(p1);
            players.Add(p2);

            Dictionary<string, List<Card>> twoDeck = DeckUtility.DivideDeck(deck);
            players[0].hands = twoDeck["first_half"];
            players[1].hands = twoDeck["second_half"];

            Play();
        }

        public void Play()
        { 
            Console.WriteLine($"Player 1: {players[0].name} Player 2: {players[1].name}");
            
            while (players[0].hands.Count != 0) {
                Console.WriteLine("Would you like to see a round?(y/n)");
                string input = Console.ReadLine();
                if (input == "n"){
                    break;
                }
                Round();
            }

            EndGame();
        }

        public void Round()
        {
            // Draw a card from each player's hand. Be sure to remove it entirely.
            // Evaluate who won the round using the cards, adjust the score, and
            // display it using the DisplayScore method
            players[0].hands = DeckUtility.ShuffleDeck(players[0].hands);
            players[1].hands = DeckUtility.ShuffleDeck(players[1].hands);

            Random r = new Random();
            int n = r.Next(0,players[1].hands.Count - 1);
            Card card1 = players[0].hands[n];
            Card card2 = players[1].hands[n];
            Console.WriteLine($"{players[0].name} has {card1.getCard()}");
            Console.WriteLine($"{players[1].name} has {card2.getCard()}");

            if (card1.value < card2.value){
                players[1].score += 1;
                Console.WriteLine($"{players[1].name} Win");
            } else if (card1.value > card2.value) {
                players[0].score += 1;
                Console.WriteLine($"{players[0].name} Win");
            } else {
                Console.WriteLine("Tie");
            }

            players[0].hands.Remove(card1);
            players[1].hands.Remove(card2);
            DisplayScore();
        }
        public void DisplayScore()
        {
            // Display each player's name and score and how many cards are left in
            // each player's hand
            Console.WriteLine($"{players[0].name} Score: {players[0].score} {players[0].hands.Count} cards left");
            Console.WriteLine($"{players[1].name} Score: {players[1].score} {players[1].hands.Count} cards left");
        }
        public void EndGame()
        {
            Console.WriteLine("Game Over");
            if(players[0].score > players[1].score){
                Console.WriteLine($"{players[0].name} is the winner");
            } else if (players[0].score < players[1].score){
                Console.WriteLine($"{players[1].name} is the winner");
            } else {
                Console.WriteLine("It's a Tie");
            }
        }
    }
}
