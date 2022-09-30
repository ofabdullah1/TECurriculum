using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public abstract class Deck
    {
        protected List<Card> Cards { get; set; } = new List<Card>();

        protected abstract string[] Suits { get; } 
        protected abstract string[] Values { get; }

        abstract protected void CreateDeck();

        public string DisplayDeck()
        {
            string result = "";

            foreach (Card item in Cards)
            {
                result += item.ToString() + "\n";
            }

            return result;
        }

        public void Shuffle()
        {
            Random random = new Random();

          for (int i = 0; i < Cards.Count; i++)
            {
                int j = random.Next(Cards.Count);
                Card temp = Cards[i];
                Cards[i] = Cards[j];
                Cards[j] = temp;
            }
        }

        public Card DealACard()
        {
            Card result = Cards[0];
            Cards.RemoveAt(0);
            return result;
        }
    }
}
