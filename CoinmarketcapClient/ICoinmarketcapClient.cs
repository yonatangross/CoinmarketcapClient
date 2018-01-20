using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coinmarketcap.Client
{
    public interface ICoinmarketcapClient
    {
        List<string> GetConvertCurrencyList();

        Currency GetCurrencyById(string id);

        Currency GetCurrencyById(string id, string convertCurrency);

        IEnumerable<Currency> GetCurrencies();

        IEnumerable<Currency> GetCurrencies(string convertCurrency);

        IEnumerable<Currency> GetCurrencies(int limit);

        IEnumerable<Currency> GetCurrencies(int limit, string convertCurrency);

        Task<IEnumerable<Currency>> GetCurrencies2(int id, string convertCurrency);
    }
}
