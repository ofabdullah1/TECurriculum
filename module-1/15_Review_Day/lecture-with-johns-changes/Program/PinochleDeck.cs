using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class PinochleDeck : Deck
    {

        protected override string[] Suits { get; } = { "Spades", "Diamonds", "Hearts", "Clubs" };
        protected override string[] Values { get; } = { "A", "9", "10", "J", "Q", "K" };

        public PinochleDeck()
        {
            CreateDeck();
        }

        //protected override string[] Values { get; } = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        protected override void CreateDeck()
        {

            foreach (string suit in Suits)
            {
                foreach (string value in Values)
                {
                    Card card = new Card(suit, value, false);
                    Cards.Add(card);
                    Cards.Add(card);
                }
            }

        }

    }
}
