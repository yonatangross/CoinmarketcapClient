namespace Coinmarketcap.Client
{
    using System;
    using System.Net.Http;

    public class CoinmarketcapApiClient : ICoinmarketcapApiClient
    {
        public HttpClient CreateClient(string i_Url)
        {
            HttpClientHandler handler = new HttpClientHandler();
            if (handler.SupportsAutomaticDecompression)
            {
                handler.AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate;
            }

            HttpClient client = new HttpClient(handler)
            {
                BaseAddress = new Uri(i_Url),
            };

            return client;
        }

    }
}