using System.Collections.Generic;

namespace CryptoFollower.Logic
{
    using NoobsMuc.Coinmarketcap.Client;

    public class ClientData
    {
        public string convertCurrency { get; set; }

        public ICoinmarketcapClient client { get; } = new CoinmarketcapClient();

        public IEnumerable<Currency> CryptCurrenciesList { get; set; } 
    }
}
