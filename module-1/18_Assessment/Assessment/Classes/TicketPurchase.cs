using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Classes
{
    public class TicketPurchase
    {

        public string Name { get; set; }

        public int NumberOfTickets { get; set; }

        public double BasePrice
        {
            get
            {
                return NumberOfTickets * 59.99;
            }
        }


       




        public TicketPurchase (string name, int numberOfTickets)
        {
            Name = name;
            NumberOfTickets = numberOfTickets;
        }



        public virtual int GetPrice(bool earlyCheckIn, bool priorityRideAccess)
        {
            if(earlyCheckIn && priorityRideAccess)
            {

                double result = (BasePrice + 60.00);
                
               
            }
            else if(earlyCheckIn && !priorityRideAccess)
            {
               double result = (BasePrice + 10.00);
                
            }
            else if(!earlyCheckIn && priorityRideAccess)
            {
                double result = (double)(BasePrice + 50.00);
              
                
            }
            else
            {
                double result = BasePrice * NumberOfTickets;
                
                
            }

            return 0;
            
            
            
            
        }
    }
}
