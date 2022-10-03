using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class UserInterface
    {
        private Deck deck;

        public void Start()
        {
            bool done = false;

            DisplayDeckChoice();

            string choiceInput = Console.ReadLine();

            if (choiceInput == "1")
            {
                deck = new PokerDeck();
                Console.WriteLine("Creating poker deck");
            }
            else
            {
                deck = new PinochleDeck();
                Console.WriteLine("Creating pincohle deck");
            }


            while (!done)
            {
                DisplayMenu();

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        DisplayTheDeck();
                        break;
                    case "2":
                        ShuffleTheDeck();
                        break;
                    case "3":
                        DealACard();
                        break;
                    case "E":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice");
                        Console.WriteLine();
                        break;
                }
            }
        }

        private void DisplayDeckChoice()
        {
            Console.WriteLine("Please choose a deck type.");
            Console.WriteLine("1 - Poker");
            Console.WriteLine("2 - Pinochle");
        }

        private void DealACard()
        {
            Card card = deck.DealACard();
            Console.WriteLine(card);
            Console.WriteLine();
        }

        private void ShuffleTheDeck()
        {
            deck.Shuffle();
            Console.WriteLine();
        }

        private void DisplayTheDeck()
        {
            string display = deck.DisplayDeck();
            Console.WriteLine(display);
            Console.WriteLine();
        }

        private void DisplayMenu()
        {
            Console.WriteLine("Please enter a choice: ");
            Console.WriteLine("1: Display the deck");
            Console.WriteLine("2: Shuffle the deck");
            Console.WriteLine("3: Deal a card");
            Console.WriteLine("E: End the program");
        }
    }
}
