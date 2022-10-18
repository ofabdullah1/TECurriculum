using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DadabaseApp
{
    // Matt's TODO List

    // Part 1: Create a Joke table and a HumorLevel table
    // Part 2: Script a few jokes and humor levels
    // Part 3: Connect the UI to the DAO
    // Part 4: List all jokes with their humor level text
    // Part 5: Insert a joke
    // Part 6: Modify a Joke
    // Part 7: ???
    // Part 8: Profit!!!

    /// <summary>
    /// This class is responsible for all user input and menu code.
    /// </summary>
    public class UserInterface
    {
        /// <summary>
        /// Lists main menu options for the user.
        /// </summary>
        public void ShowMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Matt's \"Dad-a-base\"!");
            Console.WriteLine();
            Console.WriteLine("Get it? It's funny because it\'s a database of dad jokes.");
            Console.WriteLine("You\'ll laugh later.");
            Console.WriteLine();

            bool shouldQuit = false;

            while (!shouldQuit)
            {

                Console.WriteLine("What do you want to do?");
                Console.WriteLine();

                Console.WriteLine("1) List Dad Jokes");
                Console.WriteLine("2) Add a Dad Joke");
                Console.WriteLine("3) Get Dad Jokes by Dad");
                Console.WriteLine("4) Quit");
                Console.WriteLine();

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1": // List Dad Jokes
                        throw new NotImplementedException();
                        break;

                    case "2": // Add a Dad Joke
                        throw new NotImplementedException();
                        break;

                    case "3": // Get Dad Jokes by Dad
                        throw new NotImplementedException();
                        break;

                    case "4": // Quit
                        shouldQuit = true;
                        Console.WriteLine("Have fun telling dad jokes!");
                        break;

                    default:
                        Console.WriteLine("That's not a thing. Go think about what you did.");
                        break;
                }
            }
        }
    }
}
