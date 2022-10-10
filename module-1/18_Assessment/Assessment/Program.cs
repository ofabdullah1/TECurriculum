using Assessment.Classes;
using System;
using System.Collections.Generic;
using System.Text;
namespace Assessment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create an object and call methods on it (manual testing) from this class.
            // You DO NOT need to prompt the user to type in any values

            TicketPurchase myTicket = new TicketPurchase("Omar", 2);

            decimal myPrice = myTicket.GetPrice(false, false);

            Console.WriteLine(myPrice.ToString());



        }

    }
}
