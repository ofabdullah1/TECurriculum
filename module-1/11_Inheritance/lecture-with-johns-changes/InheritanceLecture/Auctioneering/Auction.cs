﻿using System;
using System.Collections.Generic;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// This class represents a general auction.
    /// </summary>
    public class Auction
    {
        /// <summary>
        /// This is an encapsulated field that holds all placed bids.
        /// </summary>
        private List<Bid> allBids = new List<Bid>();

        /// <summary>
        /// Represents the current high bid.
        /// </summary>
        public Bid CurrentHighBid { get; protected set; } = new Bid("", 0);

        /// <summary>
        /// All placed bids returned as an array.
        /// </summary>
        public Bid[] AllBids
        {
            get { return allBids.ToArray(); }
        }

        /// <summary>
        /// Indicates if the auction has ended yet.
        /// </summary>
        public bool HasEnded { get; protected set; } = false;

        public string Description { get; private set; }

        public Auction( string description)
        {
            Description = description;
        }

        /// <summary>
        /// Places a Bid on the Auction
        /// </summary>
        /// <param name="offeredBid">The bid to place.</param>
        /// <returns>True if the new bid is the current winning bid</returns>
        public virtual bool PlaceBid(Bid offeredBid)
        {

            bool result = false;

            // Print out the bid details.
            Console.WriteLine(offeredBid.Bidder + " bid " + offeredBid.BidAmount.ToString("C"));

            //todo Record it as a bid by adding it to allBids
            allBids.Add(offeredBid);

            //todo Check to see IF the offered bid is higher than the current bid amount
            // if yes, set offered bid as the current high bid()

            if (HasEnded == true)
            {
                Console.WriteLine("Auction has ended");
            }

            else if(offeredBid.BidAmount > CurrentHighBid.BidAmount)
            {
                CurrentHighBid = offeredBid;
                result = true;
            }

            //todo Output the current high bid
            Console.WriteLine("Current high bid "+ CurrentHighBid.BidAmount.ToString("C") +
                " by " + CurrentHighBid.Bidder + " bidding on " + Description);

            //todo Return if this is the new highest bid
            return result;
        }
    }
}