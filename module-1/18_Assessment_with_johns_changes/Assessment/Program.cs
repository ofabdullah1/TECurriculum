using Assessment.Classes;
using System;

namespace Assessment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create an object and call methods on it (manual testing) from this class.
            // You DO NOT need to prompt the user to type in any values

            Ticket myTicket = new Ticket("john", 2);

            decimal myPrice = myTicket.TotalPrice(false, false);


            Console.WriteLine(myTicket.ToString());
        }
    }
}
