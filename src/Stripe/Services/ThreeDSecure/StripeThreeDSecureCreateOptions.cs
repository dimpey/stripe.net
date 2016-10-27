﻿using Newtonsoft.Json;

namespace Stripe
{
    public class StripeThreeDSecureCreateOptions
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        public string ReturnUrl { get; set; }

        [JsonProperty("return_url")]
        internal string ReturnUrlInternal
        {
            get { return ReturnUrl ?? "_callback"; }
        }

        [JsonProperty("card")]
        public string CardId { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }
    }
}
