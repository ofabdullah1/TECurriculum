using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Classes
{
    public class TicketPurchase
    {

        public string Name { get; private set; }

        public int NumberOfTickets { get; private set; }

        public decimal BasePrice
        {
            get
            {
                return NumberOfTickets * 59.99M;
            }
        }


       




        public TicketPurchase (string name, int numberOfTickets)
        {
            Name = name;
            NumberOfTickets = numberOfTickets;
        }



        public decimal GetPrice(bool earlyCheckIn, bool priorityRideAccess)
        {

            decimal price = BasePrice;


            if (earlyCheckIn)
            {

                price += (NumberOfTickets * 10);


            }
            if (priorityRideAccess)
            {
                price = NumberOfTickets * 10;

            }

            return price;
        
            
        }

        public override string ToString()
        {
            return $"Ticket - {Name} - {BasePrice}";
        }


    }
}
