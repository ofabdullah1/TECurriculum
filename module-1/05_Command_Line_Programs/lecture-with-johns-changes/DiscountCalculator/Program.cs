using System;

namespace DiscountCalculator
{
    class Program
    {
        /// <summary>
        /// The main method is the start and end of our program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Discount Calculator");

            //Console.Write("John ");
           // Console.Write("Fulton");
           // Console.WriteLine();

            // Prompt the user for a discount amount
            // The answer needs to be saved as a double
            Console.Write("Enter the discount amount (w/out percentage) for example enter 17 for 17%: ");
            string discount = Console.ReadLine();

            //Console.WriteLine("The discount amount you entered is " + discount);

            //double discountPercent = (double)discount;
            //int result = int.Parse(discount);

            double discountDouble = double.Parse(discount);
            Console.WriteLine("The discount amount as an double is " + discountDouble);

            //double itemPrice = 100.00;
            //Console.WriteLine("Before discount: " + itemPrice);
            //itemPrice = itemPrice - (discountDouble / 100 * itemPrice);
            //Console.WriteLine("After discount: " + itemPrice);



            // Prompt the user for a series of prices
            Console.Write("Please provide a series of prices (space separated): ");
            string values = Console.ReadLine();
            Console.WriteLine("The values your entered were: " + values);

            string[] prices = values.Split(" ");

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine(prices[i]);
            }

            Console.WriteLine();

            //for (int i = 0; i < prices.Length; i++)
            //{
            //    double price = double.Parse(prices[i]);
            //    price = price - (discountDouble / 100 * price);
            //    Console.WriteLine(price.ToString("C"));
            //}

             int j = 0;

            while ( j < prices.Length)
            {
                
                double price = double.Parse(prices[j]);
                price = price - (discountDouble / 100 * price);
                Console.WriteLine(price.ToString("C"));
                j++;
            }

            bool done = true;

            //while (!done)
            //{
            //    Console.WriteLine("Are you done? (yes/no)");
            //    string answer = Console.ReadLine();
            //    done = (answer == "yes") ? true : false;
            //}

            do
            {
                Console.WriteLine("Are you done? (yes/no)");
                string answer = Console.ReadLine();
                done = (answer == "yes") ? true : false;
            }
            while (!done);

        }
    }
}
