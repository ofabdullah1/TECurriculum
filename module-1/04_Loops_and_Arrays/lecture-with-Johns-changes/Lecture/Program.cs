using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Use a for-loop to print "Hello World" 10 times

            for (int i =0; i < 10; i++)
            {
                Console.WriteLine("Hellow World!");
            }

            int[] nums = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Item " + i + " is " + nums[i]);
            }


            //Console.WriteLine("Hello");

            //int x = 0;
            //Console.WriteLine("Before updates: " + x);
            //Console.WriteLine();

            //x = x + 1;
            //Console.WriteLine("After x = x + 1: " + x);
            //Console.WriteLine();

            //x += 1;
            //Console.WriteLine("After x += 1: " + x);
            //Console.WriteLine();

            //x++;
            //Console.WriteLine("After x++: " + x);
            //Console.WriteLine();

            //++x;
            //Console.WriteLine("After ++x: " + x);
            //Console.WriteLine();

            //Console.WriteLine("Using x++ in a statement: " + x++);
            //Console.WriteLine("Value of x after x++ is used in a statement: " + x);
            //Console.WriteLine();

            //Console.WriteLine("Using ++x in a statement: " + ++x);
            //Console.WriteLine("Value of x after ++x is used in a stement: " + x);
            //Console.WriteLine();

        }
    }
}
