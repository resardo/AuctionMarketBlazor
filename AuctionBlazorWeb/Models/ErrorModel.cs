﻿using Newtonsoft.Json;

namespace AuctionBlazorWeb.Models
{
    public class ErrorModel
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public override string ToString() => JsonConvert.SerializeObject(this);

        
    }
}
