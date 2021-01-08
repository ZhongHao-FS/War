using System;
namespace War
{
    public class Card
    {
        // Create a private field for the card's suit (This should be an integer)
        // It will eventually store a number from 0 to 3
	private int suit;
    public int value;

	public Card(int s,int v){
        suit = s;
        value = v;
    }
	
	public string getCard(){
        string output = "The ";

        switch (value) {
            case 1:
            output += "Ace";
            break;
            case 2:
            output += "Two";
            break;
            case 3:
            output += "Three";
            break;
            case 4:
            output += "Four";
            break; 
            case 5:
            output += "Five";
            break; 
            case 6:
            output += "Six";
            break; 
            case 7:
            output += "Seven";
            break; 
            case 8:
            output += "Eight";
            break; 
            case 9:
            output += "Nine";
            break; 
            case 10:
            output += "Ten";
            break; 
            case 11:
            output += "Jack";
            break; 
            case 12:
            output += "Queen";
            break; 
            case 13:
            output += "King";
            break; 
        }
            output += " of ";
        switch (suit) {
            case 0:
            output += "Spades";
            break;
            case 1:
            output += "Hearts";
            break;
            case 2:
            output += "Diammonds";
            break;
            case 3:
            output += "Clubs";
            break; 
        }
            return output;
    }

        // Create a public property for the value of the card. This will hold a
        // number from 1 to 13

        // Create a constructor that accepts suit and value in parameters and
        // sets the value and suit classmember variables accordingly

        //Create a method to display the value of the card. This should return a string.
        // Assume a suit of 0 is Spades, 1 is Hearts, 2 is Diammonds & 3 is Clubs
        // If the card value is 12 and suit is 0 the card
        // then this method should return "The Queen of Spades"
    }
}
