using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Deck
    {
        private List<Card> Cards { get; set; } = new List<Card>();

        private string[] suits = { "Spades", "Diamonds", "Hearts", "Clubs" };
        private string[] values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        public Deck ()
        {
            CreateDeck();
        }



        private void CreateDeck()
        {
            

            foreach(string suit in suits)
            {
                foreach (string value in values)
                {
                    Card card = new Card(suit, value, false);
                    Cards.Add(card);
                }
            }

        }

        public string DisplayDeck()
        {
            string result = "";

            foreach (Card item in Cards)
            {
                result += item.ToString() + "\n";
            }


            return result;
        }
    }
}
