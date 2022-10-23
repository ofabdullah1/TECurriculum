using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DadabaseApp
{


    /// <summary>
    /// This class is responsible for all user input and menu code.
    /// </summary>
    public class UserInterface
    {


        private JokesDAO jokes;

        public UserInterface(JokesDAO dao)
        {
            this.jokes = dao;
        }

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
                Console.WriteLine("3) Update a Dad Joke"); // Or ALL dad jokes if we're going late
                Console.WriteLine("4) Quit");
                Console.WriteLine();

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1": // List Dad Jokes
                        ListAllDadJokes();
                        break;

                    case "2": // Add a Dad Joke
                        AddJoke();
                        break;

                    case "3": // Update
                        UpdateAllJokes();
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



        public void UpdateAllJokes()
        {
            // Call to the database to update all jokes
            int modifiedCount = jokes.UpdateAllJokes(1);

            // Display the # of updated jokes
            Console.WriteLine("Marked " + modifiedCount + "joke(s) as atrocities");
        }

        public void AddJoke()
        {
            // Ask the user for info about the joke
            Joke joke = new Joke();
            Console.WriteLine("Whats the joke setup?");
            string setup = Console.ReadLine();

            Console.WriteLine("Whats the joke's punchline?");
            string punchline = Console.ReadLine();

            joke.Setup = setup;
            joke.Punchline = punchline;
            joke.HumorLevelId = 4; // Default to a slightly funny level

            // Add the joke to the database
            int id = jokes.InsertJoke(joke);

            // Display the ID of the new joke to the user
            Console.WriteLine("This joke has an ID of " + id);
        }

        public void ListAllDadJokes()
        {
            //Get a list of dad jokes
            List<Joke> alljokes = this.jokes.GetAllJokes();

            // Loop over the list of dad jokes and pring each one to the screen
            foreach (Joke badJoke in alljokes)
            {
                Console.WriteLine(badJoke);
            }
        }
    }
}
