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

            // Prompt the user for a discount amount
            // The answer needs to be saved as a double
            Console.Write("Enter the discount amount (w/out percentage) for example enter 17 for 17%: ");
            string discount = Console.ReadLine();

            //Console.WriteLine("The discount amount you entered is " + discount);

            //double discountPercent = Int32.Parse(discount);
            //int result = int.Parse(discount);

            double discountDouble = double.Parse(discount);

            Console.WriteLine("The discount amount as a double is " + discountDouble);

            //double itemPrice = 100.00;
            //Console.WriteLine("Before discount: " + itemPrice);
            //itemPrice = itemPrice - (discountDouble / 100 * itemPrice);
            //Console.WriteLine("Your new price is " + itemPrice);



            // Prompt the user for a series of prices
            Console.Write("Please provide a series of prices (space separated): ");
            string values = Console.ReadLine();
            Console.WriteLine("The values you entered were: " + values);

            string[] prices = values.Split(" ");

            for (int j = 0; j < prices.Length; j++)
            {
                Console.WriteLine(prices[j]);
            }

            Console.WriteLine();

            for (int j = 0; j < prices.Length; j++)
            {
                double price = double.Parse(prices[j]);
                price = price - (discountDouble / 100 * price);
                Console.WriteLine(price.ToString("C"));
            }

            int i = 0;


            //while (i < prices.Length)
            //{
            //    double price = double.Parse(prices[i]);
            //    price = price - (discountDouble / 100 * price);
            //    Console.WriteLine(price.ToString("C"));
            //    i++;
        }

        bool done = false;

        //while (!done)
        //{
        //    Console.WriteLine("Are you done? (yes/no)");
        //    string answer = Console.ReadLine();
        //    done = (answer == "yes") ? true : false;
        //}

        //do
        //{
        //    Console.WriteLine("Are you done? (yes/no)");
        //    string asnwer = Console.ReadLine();
        //    done = (asnwer == "yes") ? true : false;
        //}
        //while (!done);
    }
}

