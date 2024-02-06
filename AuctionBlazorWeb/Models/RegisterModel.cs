using System.ComponentModel.DataAnnotations;

namespace AuctionBlazorWeb.Models
{
    public class RegisterModel
    {
        [Required, MinLength(3), MaxLength(20)]
        public string Username { get; set; }

        [Required, MinLength(3), MaxLength(20)]
        public string FirstName { get; set; }

        [Required, MinLength(3), MaxLength(20)]
        public string LastName { get; set; }

        [Required, MinLength(8)]
        public string Password { get; set; }

        public List<Guid>? RoleId { get; set; }

    }
}
