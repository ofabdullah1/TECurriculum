using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Card
    {
        private string v;

        public string Suit { get; set; }
        public string Value { get; set; }
        public bool IsFaceUp { get; set; }


        public Card(string suit, string value, bool isFaceUp)
        {
            Suit = suit;
            Value = value;
            IsFaceUp = isFaceUp;
        }

        public Card(string v)
        {
            this.v = v;
        }

        public override string ToString()
        {
            return Value + " of "+ Suit + ((IsFaceUp) ? " is face up" : " is face down");
        }


    }
}
