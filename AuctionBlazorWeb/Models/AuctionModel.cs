using System.ComponentModel.DataAnnotations;

namespace AuctionBlazorWeb.Models
{
    public class AuctionModel
    {
        public Guid AuctionId { get; set; }
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [MinLength(3, ErrorMessage = "Title must be at least 3 characters long.")]
        [MaxLength(20, ErrorMessage = "Title must be no more than 20 characters long.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [MinLength(10, ErrorMessage = "Description must be at least 10 characters long.")]
        [MaxLength(100, ErrorMessage = "Description must be no more than 100 characters long.")]
        public string Description { get; set; }

        public DateTime StartTime { get; set; }
        
        [Required(ErrorMessage = "EndTIme is required.")]
        public DateTime EndTime { get; set; }

        [Required(ErrorMessage = "StartPrice is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "StartPrice must be greater than or equal to 0.")]
        public decimal StartPrice { get; set; }
        
    }
}
