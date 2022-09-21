using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
    {
        static void Main(string[] args)
        {

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


            // Declaring and initializing a Dictionary

            Dictionary<int, double> temps = new Dictionary<int, double>();

            // Adding an item to a Dictionary

            //temps.Add(1, 78.5);
            //temps.Add(1, 45.3);


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
}
