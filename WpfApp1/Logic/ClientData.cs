using System.Collections.Generic;

namespace WpfApp1.Logic
{

    public class ClientData
    {
        public string convertCurrency { get; set; }

        public ICoinmarketcapClient client { get; } = new CoinmarketcapClient();

        public IEnumerable<Currency> CryptCurrenciesList { get; set; } 
    }
}
