namespace InheritanceLecture.Auctioneering
{
    public class Bid
    {
        /// <summary>
        /// Holds bidder name.
        /// </summary>
        public string Bidder { get; }

        /// <summary>
        /// The bid amount in whole dollars.
        /// </summary>
        public int BidAmount { get; }
        /// <summary>
        /// Constructor for Bid object. Each Bid requires a bidder and bidAmount
        /// </summary>
        /// <param name="bidder">Who is bidding</param>
        /// <param name="bidAmount">How much bid is for</param>
        public Bid(string bidder, int bidAmount)
        {
            Bidder = bidder;
            BidAmount = bidAmount;
        }
    }
}
