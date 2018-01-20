using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp.Portable;

namespace Coinmarketcap.Client
{
    using System;

    public class CoinmarketcapClient : ICoinmarketcapClient
    {
        private const string k_Separator = "&";
        private const string k_Url = "http://api.coinmarketcap.com";
        private const string k_Path = "/v1/ticker";

        private const string k_ApiVersion = "/v1/";

        List<string> ICoinmarketcapClient.GetConvertCurrencyList()
        {
            return new List<string> { "ILS", "EUR", "AUD", "BRL", "CAD", "CHF", "CNY", "GBP", "HKD", "IDR", "INR", "JPY", "KRW", "MXN", "RUB", };
        }

        Currency ICoinmarketcapClient.GetCurrencyById(string i_Id)
        {
            return currencyById(i_Id, string.Empty);
        }

        Currency ICoinmarketcapClient.GetCurrencyById(string i_Id, string i_ConvertCurrency)
        {
            return currencyById(i_Id, i_ConvertCurrency);
        }

        private static Currency currencyById(string i_Id, string i_ConvertCurrency)
        {
            string path = "/" + i_Id;
            if (!string.IsNullOrEmpty(i_ConvertCurrency))
            {
                path += "/?convert=" + i_ConvertCurrency;
            }

            WebApiClient client = new WebApiClient(k_Url);
            List<Currency> result = client.MakeRequest(k_Path + path, Method.GET, i_ConvertCurrency);

            return result.First();
        }

        private static async Task<List<Currency>> asyncCurrencies(int i_Limit, string i_ConvertCurrency)
        {
            string path = "?";
            path += "limit=" + i_Limit;

            if (!string.IsNullOrEmpty(i_ConvertCurrency))
            {
                path += k_Separator + "convert=" + i_ConvertCurrency;
            }

            WebApiClient client = new WebApiClient(k_Url);
            List<Currency> result2 = client.MakeHttpRequest(k_Path + path, i_ConvertCurrency);
            return result2;
        }

        IEnumerable<Currency> ICoinmarketcapClient.GetCurrencies()
        {
            return this.currencies(-1, string.Empty);
        }

        IEnumerable<Currency> ICoinmarketcapClient.GetCurrencies(string i_ConvertCurrency)
        {
            return this.currencies(-1, i_ConvertCurrency);
        }

        IEnumerable<Currency> ICoinmarketcapClient.GetCurrencies(int i_Limit)
        {
            return this.currencies(i_Limit, string.Empty);
        }

        IEnumerable<Currency> ICoinmarketcapClient.GetCurrencies(int i_Limit, string i_ConvertCurrency)
        {
            return this.currencies(i_Limit, i_ConvertCurrency);
        }

        public async Task<IEnumerable<Currency>> GetCurrencies2(int i_Limit, string i_ConvertCurrency)
        {
            List<Currency> currencies = await asyncCurrencies(i_Limit, i_ConvertCurrency);

            return currencies;
        }

        private IEnumerable<Currency> currencies(int i_Limit, string i_ConvertCurrency)
        {
            string path = "?";
            path += "limit=" + i_Limit;

            if (!string.IsNullOrEmpty(i_ConvertCurrency))
            {
                path += k_Separator + "convert=" + i_ConvertCurrency;
            }

            WebApiClient client = new WebApiClient(k_Url);
            List<Currency> result = client.MakeRequest(k_Path + path, Method.GET, i_ConvertCurrency);

            return result;
        }
    }

    public async Task<IEnumerable<Currency>> GetSpecificCurrency(string i_CurrencyId)
    {
        SpecificCurrencyTickerApiMethod specificCurrencyTickerApiMethod = new SpecificCurrencyTickerApiMethod(i_CurrencyId);
        createPath(specificCurrencyTickerApiMethod)

        return currency;
    }

    internal interface IApiMethod
    {
        string Endpoint { get; set; }

        Method RestMethod { get; set; }

        Dictionary<string, string> OptionalParametersDictionary { get; set; }
    }

    public class TickerApiMethod : IApiMethod
    {
        public string Endpoint { get; set; } = "ticker";

        public Method RestMethod { get; set; } = Method.GET;

        public Dictionary<string, string> OptionalParametersDictionary { get; set; } =
            new Dictionary<string, string> { { "start", string.Empty }, { "limit", string.Empty }, { "convert", string.Empty }, };
    }

    public class SpecificCurrencyTickerApiMethod : TickerApiMethod
    {
        public SpecificCurrencyTickerApiMethod(string i_CurrencyId)
        {
            Endpoint = Endpoint + "/" + i_CurrencyId;
            OptionalParametersDictionary = new Dictionary<string, string> { { "convert", string.Empty } };
        }
    }

    public class GlobalDataApiMethod : IApiMethod
    {
        public string Endpoint { get; set; } = "global";

        public Method RestMethod { get; set; } = Method.GET;

        public Dictionary<string, string> OptionalParametersDictionary { get; set; } =
            new Dictionary<string, string> { { "convert", string.Empty }, };
    }
}
