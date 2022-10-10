using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Classes
{
    class Ticket
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

        public Ticket(string name, int numberOfTickets)
        {
            Name = name;
            NumberOfTickets = numberOfTickets;
        }

        public decimal TotalPrice(bool earlyCheckIn,  
            bool priorityRideAccess)
        {
            decimal price = BasePrice;

            if(earlyCheckIn  == true)
            {
                price += NumberOfTickets * 10;
            }

            if (priorityRideAccess)
            {
                price += NumberOfTickets * 50;
            }

            return price;
        }

        public override string ToString()
        {
            return $"TICKET - {Name} - {BasePrice}";
        }
    }
}
