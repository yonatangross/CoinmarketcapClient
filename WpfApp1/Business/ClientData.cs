namespace WpfApp1.Business
{
    using System.Collections.Generic;
    using Coinmarketcap.Client;

    public class ClientData
    {
        public string convertCurrency { get; set; }

        public ICoinmarketcapClient client { get; } = new CoinmarketcapClient();

        public IEnumerable<Currency> CryptCurrenciesList { get; set; } 
    }
}
