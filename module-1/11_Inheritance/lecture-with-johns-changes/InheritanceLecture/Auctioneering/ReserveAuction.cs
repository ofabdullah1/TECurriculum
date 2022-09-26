using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class ReserveAuction : Auction
    {

        public int ReserveAmount { get; private set; }

        public ReserveAuction(string description, int reserveAmount) :base(description)
        {
            ReserveAmount = reserveAmount;
        }


        public override bool PlaceBid(Bid newBid)
        {
            if (newBid.BidAmount >= ReserveAmount)
            {
                bool result = base.PlaceBid(newBid);
                return result;
            }
            else
            {
                Console.WriteLine("Bid does not meet reserve amount.");
                return false;
            }

        }
    }
}
