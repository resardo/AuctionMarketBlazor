using System.Text;

namespace AuctionBlazorWeb.Helpers
{
    public static class JwtDecoder
    {
        public static string DecodePayload(string token)
        {
            var parts = token.Split('.');
            if (parts.Length != 3)
            {
                throw new ArgumentException("Invalid JWT token format.");
            }

            var payload = parts[1];
            var decodedBytes = Convert.FromBase64String(AddPaddingToBase64(payload));
            var decodedPayload = Encoding.UTF8.GetString(decodedBytes);

            return decodedPayload;
        }

        private static string AddPaddingToBase64(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return base64.Replace('-', '+').Replace('_', '/');
        }
    }
}
