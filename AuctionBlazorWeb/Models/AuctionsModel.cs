namespace AuctionBlazorWeb.Models
{
    public class AuctionsModel
    {
        public Guid AuctionId { get; set; }


        public Guid UserId { get; set; }


        public string Title { get; set; }


        public string Description { get; set; }


        public DateTime StartTime { get; set; }


        public DateTime EndTime { get; set; }


        public decimal StartPrice { get; set; }

        public bool IsAvailable { get; set; }

        public UserModel User { get; set; }
    }

    public class UserModel
    {

        public Guid UserId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public decimal Wallet { get; set; } = 1000.00M;

        public List<Guid> RoleId { get; set; }
    }


  
}
