using System;
using System.Collections.Generic;

namespace War
{
    public class Player
    {  
        public List<Card> hands;

        public string name;
        public int score;
        
        public Player(string n){
            name = n;
        }
    }
}
