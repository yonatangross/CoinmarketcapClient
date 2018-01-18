namespace CoinCapClient.Test
{
    using NoobsMuc.Coinmarketcap.Client;

    public class Program
    {
        public static void Main()
        {
            ICoinmarketcapClient client = new CoinmarketcapClient();
            var currencies = client.GetCurrencies(50);
        }
    }
}
