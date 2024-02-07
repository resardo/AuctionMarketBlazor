namespace AuctionBlazorWeb.Services
{
    public class WalletService
    {
        public decimal WalletBalance { get; private set; }
        public decimal TotalBidsBalance { get; private set; }

        public event Action OnChange;

        public void UpdateWallet(decimal newBalance)
        {
            WalletBalance = newBalance;
            NotifyStateChanged();
        }

        public void TotalBids(decimal newBalance)
        {
            TotalBidsBalance = newBalance;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
