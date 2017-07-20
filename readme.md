## C# Client for  coinmarketcap ##

Here is an .Net Client for the [Coinmarket Api](https://coinmarketcap.com/api/)

## Available for:
- .net Standart 1.1
- .net Standart 1.3
- .net 4.5

## Example:
```csharp
	ICoinmarketcapClient client = new CoinmarketcapClient();
	Currency currency = client.GetCurrencyById("bitcoin");
```

## Licence:
http://choosealicense.com/licenses/bsd-2-clause/

## Todo:
At the moment we don't return the converted currency. 
The will be implemented in version 1.0