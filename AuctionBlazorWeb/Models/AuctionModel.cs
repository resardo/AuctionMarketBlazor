using System.ComponentModel.DataAnnotations;

namespace AuctionBlazorWeb.Models
{
    public class AuctionModel
    {
        public Guid AuctionId { get; set; }
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Title is required."), MinLength(3), MaxLength(20)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required."), MinLength(10), MaxLength(100)]
        public string Description { get; set; }

        [Required(ErrorMessage = "StartTime is required.")]
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [Required(ErrorMessage = "StartPrice is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "StartPrice must be greater than or equal to 0.")]
        public decimal StartPrice { get; set; }
        
    }
}
