namespace Coinmarketcap.Client
{
    using System.Net.Http;

    public interface ICoinmarketcapApiClient
    {
        HttpClient CreateClient(string i_Resource = null);
    }
}
