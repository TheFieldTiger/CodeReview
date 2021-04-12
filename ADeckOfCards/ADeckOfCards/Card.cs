using System;
using System.Collections.Generic;
using System.Text;

namespace ADeckOfCards
{
    class Card
    {
        public String CardType;
        public String CardSubType;
        public void DisplayCard()
        {
            Console.WriteLine("Card Suit: "+CardType);
            Console.WriteLine("Card Value: " + CardSubType);
        }
    }

    
}
