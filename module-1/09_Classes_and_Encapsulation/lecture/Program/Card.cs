using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Card
    {
        public string Suit { get; set; }
        public string Value { get; set; }
        public bool IsFaceUp { get; set; }


        public Card (string suit, string value, bool isFaceUp)
        {
            Suit = suit;
            Value = value;
            IsFaceUp = isFaceUp;
        }


        public override string ToString()
        {
            return Suit + " - " + Value + ((IsFaceUp) ? "Is face up" : "is face down");
        }


    }
}
