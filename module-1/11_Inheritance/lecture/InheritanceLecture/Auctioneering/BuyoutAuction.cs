using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    class BuyoutAuction : Auction
    {
        public int BuyoutAmount { get; private set; }

        public BuyoutAuction(string description, int buyoutAmount) :base(description)
        {
            BuyoutAmount = buyoutAmount;
        }

        public override bool PlaceBid(Bid newBid)
        {
            if (HasEnded == true)
            {
                Console.WriteLine("Auction has ended");
                return false;
            }
            if(newBid.BidAmount >= BuyoutAmount)
            {
                HasEnded = true;
                CurrentHighBid = newBid;
                Console.WriteLine("Auction has ended");
                Console.WriteLine("Winner is " + newBid.Bidder + " for " + newBid.BidAmount);
                return true;
            }
            else
            {
                return base.PlaceBid(newBid);
            }


        }


    }
}
