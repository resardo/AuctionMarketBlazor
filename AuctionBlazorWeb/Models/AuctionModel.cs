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
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal StartPrice { get; set; }
        
    }
}
