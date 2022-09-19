using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a series of decimal values (separated by spaces): ");
            string decimalValues = Console.ReadLine();

            string[] binaries = decimalValues.Split(" ");
            for (int i = 0; i < binaries.Length; i++)
            {
                Console.WriteLine(binaries[i]);
            }

                Console.WriteLine();

            for (int i = 0; i < binaries.Length; i++)

            {

                int newBinary = int.Parse(binaries[i]);
                string listValues = Convert.ToString(newBinary, 2);
                Console.WriteLine(newBinary + " in binary is " + listValues);

            }
        }
    }
}
