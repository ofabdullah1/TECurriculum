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

            Auction generalAuction = new Auction();

            generalAuction.PlaceBid(new Bid("Josh", 1));
            Console.WriteLine("High bidder is " + generalAuction.CurrentHighBid.Bidder);
            Console.WriteLine("Winning bid is " + generalAuction.CurrentHighBid.BidAmount);
            Console.WriteLine();

            generalAuction.PlaceBid(new Bid("Fonz", 23));
            Console.WriteLine("High bidder is " + generalAuction.CurrentHighBid.Bidder);
            Console.WriteLine("Winning bid is " + generalAuction.CurrentHighBid.BidAmount);
            Console.WriteLine();

            generalAuction.PlaceBid(new Bid("Rick Astley", 13));
            Console.WriteLine("High bidder is " + generalAuction.CurrentHighBid.Bidder);
            Console.WriteLine("Winning bid is " + generalAuction.CurrentHighBid.BidAmount);
            Console.WriteLine();

            generalAuction.PlaceBid(new Bid("Josh", 25));
            Console.WriteLine("High bidder is " + generalAuction.CurrentHighBid.Bidder);
            Console.WriteLine("Winning bid is " + generalAuction.CurrentHighBid.BidAmount);
            Console.WriteLine();

            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids



            Console.ReadLine();
        }
    }
}
