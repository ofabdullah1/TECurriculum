﻿using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD


			HashSet<int> numbers = new HashSet<int>();

			numbers.Add(3);
			numbers.Add(3);
			numbers.Add(3);
			numbers.Add(1);
			numbers.Add(1);
			numbers.Add(2);
			numbers.Add(5);

			foreach( int item in numbers)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();


			List<int> result = new List<int>();
			result.AddRange(numbers);
			result.Sort();

			foreach (int item in result)
			{
				Console.WriteLine(item);

			}


			Console.WriteLine("####################");
			Console.WriteLine("       DICTIONARIES");
			Console.WriteLine("####################");
			Console.WriteLine();
=======
>>>>>>> 2b84715bbddf3b5d7057209e22a89b6d741dde27

            HashSet<int> numbers = new HashSet<int>();

            numbers.Add(3);
            numbers.Add(3);
            numbers.Add(3);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(5);

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

<<<<<<< HEAD
			Dictionary<int, double> temps = new Dictionary<int, double>();




			// Adding an item to a Dictionary


			temps.Add(1, 78.5);
			temps.Add(2, 84.5);
			temps.Add(23, 94.6);
			temps.Add(3, 88.9);

			temps[1] = 78.5;
			temps[1] = 85.5; //square bracket notation will add and replace. .Add will not replace and will cause an error.

			temps[30] = 85.7;
=======
            Console.WriteLine();


            List<int> result = new List<int>();
            result.AddRange(numbers);
            result.Sort();
>>>>>>> 2b84715bbddf3b5d7057209e22a89b6d741dde27

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

<<<<<<< HEAD
            // Retrieving an item from a Dictionary
=======
>>>>>>> 2b84715bbddf3b5d7057209e22a89b6d741dde27

            
			
			Console.WriteLine(temps[30]);

<<<<<<< HEAD
            Console.WriteLine(temps[30]);

			if (temps.ContainsKey(3))
            {
                Console.WriteLine(temps[3]);
            }
			else
            {
                Console.WriteLine("Key doesn't exist");
            }

            Console.WriteLine();
            // Retrieving just the keys from a Dictionary





			
			
			// Loop through and display keys
			foreach(int key in temps.Keys)
            {
                Console.WriteLine(key);
            }


            Console.WriteLine();
=======
>>>>>>> 2b84715bbddf3b5d7057209e22a89b6d741dde27

            // Check to see if a key already exists



<<<<<<< HEAD


            // Iterate through the key-value pairs in the Dictionary

            Console.WriteLine(temps.Count);
			foreach(KeyValuePair<int, double> kvp in temps)
            {
				Console.WriteLine(kvp.Key + " - " + kvp.Value); 
            }

            Console.WriteLine();

=======
            Console.WriteLine("####################");
            Console.WriteLine("       DICTIONARIES");
            Console.WriteLine("####################");
>>>>>>> 2b84715bbddf3b5d7057209e22a89b6d741dde27
            Console.WriteLine();


            // Declaring and initializing a Dictionary

<<<<<<< HEAD
			temps.Remove(23);
			
			foreach (KeyValuePair<int, double> kvp in temps)
			{
				Console.WriteLine(kvp.Key + " - " + kvp.Value);
			}

=======
            Dictionary<int, double> temps = new Dictionary<int, double>();

            // Adding an item to a Dictionary
>>>>>>> 2b84715bbddf3b5d7057209e22a89b6d741dde27

            //temps.Add(1, 78.5);
            //temps.Add(1, 45.3);

<<<<<<< HEAD
			// loop through again to show item was removed

			temps.Clear();
			foreach (KeyValuePair<int, double> kvp in temps)
			{
				Console.WriteLine(kvp.Key + " - " + kvp.Value);
			}
		
		
		}
	}
=======

            temps[1] = 78.5;
            temps[1] = 45.3;
            temps[23] = 76.3;

            temps[30] = 85.7;




            // Retrieving an item from a Dictionary

            Console.WriteLine(temps[30]);

            if (temps.ContainsKey(3))
            {
                Console.WriteLine(temps[3]);
            }
            else
            {
                Console.WriteLine("Key doesn't exist");
            }



            Console.WriteLine();

            // Retrieving just the keys from a Dictionary


            // Loop through and display keys

            foreach(int key in temps.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine();

            // Check to see if a key already exists



            // Iterate through the key-value pairs in the Dictionary

            Console.WriteLine(temps.Count);
            foreach (KeyValuePair<int, double> kvp in temps)
            {
                Console.WriteLine(kvp.Key + " - " + kvp.Value);
            }

            Console.WriteLine();

            Console.WriteLine();
            // Remove an element from the Dictionary

            temps.Remove(23);

            Console.WriteLine(temps.Count);
            foreach (KeyValuePair<int, double> kvp in temps)
            {
                Console.WriteLine(kvp.Key + " - " + kvp.Value);
            }

            Console.WriteLine();

            // loop through again to show item was removed

            temps.Clear();
            Console.WriteLine(temps.Count);
            foreach (KeyValuePair<int, double> kvp in temps)
            {
                Console.WriteLine(kvp.Key + " - " + kvp.Value);
            }



        }
    }
>>>>>>> 2b84715bbddf3b5d7057209e22a89b6d741dde27
}