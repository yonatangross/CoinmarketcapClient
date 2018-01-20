using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;

namespace Coinmarketcap.Client
{
    using System;
    using System.Net;
    using System.Net.Http;

    public class WebApiClient
    {
        private IRestClient RestClient { get; }

        private HttpClient HttpClient { get; }

        public WebApiClient(string i_Url)
        {
            RestClient = new RestClient(i_Url);
            HttpClient =
                new HttpClient(
                    new HttpClientHandler
                        {
                            AutomaticDecompression =
                                DecompressionMethods.GZip | DecompressionMethods.Deflate
                        }) {
                               BaseAddress = new Uri(i_Url) 
                           };
        }

        public List<Currency> MakeHttpRequest(string resource, string convert)
        {
            string content;
            using (HttpClient)
            {
                HttpResponseMessage response = HttpClient.GetAsync(resource).Result;
                response.EnsureSuccessStatusCode();
                content = response.Content.ReadAsStringAsync().Result;
            }

            convert = convert.ToLower();
            if (!string.IsNullOrEmpty(convert))
            {
                content = content.Replace("price_" + convert, "price_convert");
                content = content.Replace("24h_volume_" + convert, "24h_volume_convert");
                content = content.Replace("market_cap_" + convert, "market_cap_convert");
            }

            List<Currency> result = JsonConvert.DeserializeObject<List<Currency>>(content);
            result.ForEach(i_Currency => i_Currency.ConvertCurrency = convert);
            return result;
        }

        public List<Currency> MakeRequest(string i_Resource, Method i_Method, string i_ConvertCurrency)
        {
            RestRequest request = new RestRequest(i_Resource, i_Method);
            Task<IRestResponse> task = RestClient.Execute(request);
            string content = task.Result.Content;

            if (!string.IsNullOrEmpty(i_ConvertCurrency))
            {
                updateCurrencyFields(i_ConvertCurrency, ref content);
            }

            List<Currency> result = JsonConvert.DeserializeObject<List<Currency>>(content);
            result.ForEach(i_Currency => i_Currency.ConvertCurrency = i_ConvertCurrency);
            return result;
        }

        private static void updateCurrencyFields(string i_ConvertCurrency, ref string io_Content)
        {
            i_ConvertCurrency = i_ConvertCurrency.ToLower();
            io_Content = io_Content.Replace("price_" + i_ConvertCurrency, "price_convert");
            io_Content = io_Content.Replace("24h_volume_" + i_ConvertCurrency, "24h_volume_convert");
            io_Content = io_Content.Replace("market_cap_" + i_ConvertCurrency, "market_cap_convert");
        }

        public Task<IRestResponse> MakeRestRequest(string i_Resource, Method i_Method)
        {
            RestRequest request = new RestRequest(i_Resource, i_Method);
            return RestClient.Execute(request);
        }

        public static RestRequest CreateRequest(string resource, Method method)
        {
            RestRequest taskRequest = new RestRequest(resource, method);
            taskRequest.Parameters.Clear();

            //here you can add some headers
            //taskRequest.AddHeader("Authorization", $"Bearer myToken");

            return taskRequest;
        }
    }
}
