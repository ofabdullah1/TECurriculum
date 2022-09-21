using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");

			List<int> myInts = new List<int>();

			List<string> names = new List<string> { "Matt", "John", "Steve", "Brian" };

			Console.WriteLine(myInts.Count);
            
			//writes the names in the list names
			Console.WriteLine(names.Count);
            
			for (int i = 0; i<names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine();
			
			names.Add("Scott");

			for (int i = 0; i < names.Count; i++)
			{
				Console.WriteLine(names[i]);
			}
			Console.WriteLine(names.Count);

            Console.WriteLine();

			names.Insert(0, "Laura");

			for (int i = 0; i < names.Count; i++)
			{
				Console.WriteLine(names[i]);
			}
			Console.WriteLine(names.Count);

            Console.WriteLine();


			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

			
			int position = names.IndexOf("Scott");
			
			names.RemoveAt(position);
			names.Insert(0,"Scott");

			for (int i = 0; i < names.Count; i++)
			{
				Console.WriteLine(names[i]);
			}
			Console.WriteLine(names.Count);

			Console.WriteLine();

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");

			names.Add("John");

			Display(names);

            Console.WriteLine();


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			names.Insert(names.Count / 2, "About the middle");
			Display(names);


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");

			


			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");


			position = names.IndexOf("Laura");

			Console.WriteLine(position);

			Console.WriteLine((position == -1) ? "Not found!" : "Good Job!");
            Console.WriteLine();

			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");

			string[] result = names.ToArray();

			foreach(string item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");

			names.Sort();
			Display(names);
            Console.WriteLine();


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");

			names.Reverse();
			Display(names);
            Console.WriteLine();

			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

			Stack<int> myStack = new Stack<int>();

			myStack.Push(3);
			myStack.Push(1);
			myStack.Push(4);
			myStack.Push(1);
			myStack.Push(5);

            Console.WriteLine(myStack.Count);
            Console.WriteLine();

			foreach(int item in myStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

			while (myStack.Count > 0)
            {
                Console.WriteLine("item is: " + myStack.Pop() + " Length is: " + myStack.Count);
            }

            Console.WriteLine();

			Console.WriteLine("####################");
			Console.WriteLine("       QUEUE");
			Console.WriteLine("####################");
			Console.WriteLine();


			Queue<string> myQueue = new Queue<string>();
			
			
			myQueue.Enqueue("Primrose");
			myQueue.Enqueue("Gabriel");
			myQueue.Enqueue("Penny");
			myQueue.Enqueue("Bella");

            Console.WriteLine(myQueue.Count);

			foreach(string pet in myQueue)
            {
                Console.WriteLine(pet);
            }

			string firstPet = myQueue.Dequeue();
            Console.WriteLine(myQueue.Count);

			foreach (string pet in myQueue)
            {
                Console.WriteLine(pet);
            }
		}

		static void Display (List<string> items)
        {

			for (int i = 0; i < items.Count; i++)
			{
				Console.WriteLine(items[i]);
			}
			Console.WriteLine(items.Count);

			Console.WriteLine();
		}
	}
}
