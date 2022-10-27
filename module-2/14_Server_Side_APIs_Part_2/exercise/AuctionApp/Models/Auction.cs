using System.ComponentModel.DataAnnotations;

namespace AuctionApp.Models
{
    public class Auction
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string User { get; set; }

        [Range(1,1000000)]
        public double CurrentBid { get; set; }
    }
}
