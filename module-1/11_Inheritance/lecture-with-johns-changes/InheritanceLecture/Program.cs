using InheritanceLecture.Auctioneering;
using System;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new general auction
            Console.WriteLine("Starting a general auction");
            Console.WriteLine("-----------------");

            BuyoutAuction reserveAuction = new BuyoutAuction("watering card", 20);

            //Bid bid = new Bid("Josh",1);
            //reserveAuction.PlaceBid(bid);

            reserveAuction.PlaceBid(new Bid("Josh", 1));

            Console.WriteLine("High bidder is " + reserveAuction.CurrentHighBid.Bidder);
            Console.WriteLine("Winning bid is " + reserveAuction.CurrentHighBid.BidAmount);
            Console.WriteLine();

            reserveAuction.PlaceBid(new Bid("Fonz", 23));
            Console.WriteLine("High bidder is " + reserveAuction.CurrentHighBid.Bidder);
            Console.WriteLine("Winning bid is " + reserveAuction.CurrentHighBid.BidAmount);
            Console.WriteLine();

            reserveAuction.PlaceBid(new Bid("Rick Astley", 13));
            Console.WriteLine("High bidder is " + reserveAuction.CurrentHighBid.Bidder);
            Console.WriteLine("Winning bid is " + reserveAuction.CurrentHighBid.BidAmount);
            Console.WriteLine();

            reserveAuction.PlaceBid(new Bid("Josh", 25));
            Console.WriteLine("High bidder is " + reserveAuction.CurrentHighBid.Bidder);
            Console.WriteLine("Winning bid is " + reserveAuction.CurrentHighBid.BidAmount);
            Console.WriteLine();

            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids



            Console.ReadLine();
        }
    }
}
