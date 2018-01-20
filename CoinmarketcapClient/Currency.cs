using Newtonsoft.Json;

namespace Coinmarketcap.Client
{
    public class Currency
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }

        public string Rank { get; set; }

        [JsonProperty(PropertyName = "price_usd")]
        public string PriceUsd { get; set; }
        [JsonProperty(PropertyName = "price_btc")]
        public string PriceBtc { get; set; }
        [JsonProperty(PropertyName = "24h_volume_usd")]
        public string volume24HUsd { get; set; }
        [JsonProperty(PropertyName = "market_cap_usd")]
        public string MarketCapUsd { get; set; }
        [JsonProperty(PropertyName = "available_supply")]
        public string AvailableSupply { get; set; }
        [JsonProperty(PropertyName = "total_supply")]
        public string TotalSupply { get; set; }
        [JsonProperty(PropertyName = "percent_change_1h")]
        public string percentChange1H { get; set; }
        [JsonProperty(PropertyName = "percent_change_24h")]
        public string percentChange24H { get; set; }
        [JsonProperty(PropertyName = "percent_change_7d")]
        public string percentChange7D { get; set; }
        [JsonProperty(PropertyName = "last_updated")]
        public string LastUpdated { get; set; }
        [JsonProperty(PropertyName = "price_convert")]
        public string PriceConvert { get; set; }
        [JsonProperty(PropertyName = "24h_volume_convert")]
        public string Volume24Convert { get; set; }
        [JsonProperty(PropertyName = "market_cap_convert")]
        public string MarketCapConvert { get; set; }

        public string ConvertCurrency { get; set; }
    }
}
