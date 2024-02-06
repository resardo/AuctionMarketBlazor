using System.ComponentModel.DataAnnotations;

namespace AuctionBlazorWeb.Models
{
    public class BidModel
    {
        public Guid BidId { get; set; }

        public Guid AuctionId { get; set; }

        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Bid amount is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Bid amount must be greater than or equal to 0.")]
        public decimal Amount { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
